//
// Copyright (c) Microsoft Corporation.    All rights reserved.
//

// Enable this macro to shift object pointers from the beginning of the header to the beginning of the payload.
#define CANONICAL_OBJECT_POINTERS

#define LLVM

namespace Microsoft.Zelig.Runtime
{
    using System;
    using System.Runtime.InteropServices;
    using TS = Microsoft.Zelig.Runtime.TypeSystem;


    [TS.WellKnownType("Microsoft_Zelig_Runtime_ObjectHeader")]
    [TS.NoVTable]
    [TS.DisableAutomaticReferenceCounting]
    [TS.DisableReferenceCounting]
    public class ObjectHeader
    {
        // Note the GarbageCollectorMask has to be the last byte, we rely on this in GarbageCollectorState property
        const uint GarbageCollectorMask  = 0x000000FF;
        const int  GarbageCollectorShift = 0;

        const uint ExtensionKindMask     = 0x00000300;
        const int  ExtensionKindShift    = 8;

        const uint ExtensionPayloadMask  = 0x00FFFC00;
        const int  ExtensionPayloadShift = 10;

        public const uint ReferenceCountMask  = 0xFF000000;
        public const int  ReferenceCountShift = 24;

        [Flags]
        public enum GarbageCollectorFlags : uint
        {
            Unmarked               = 0x00000000,
            Marked                 = 0x00000001,
            MutableMask            = 0x00000001,

            FreeBlock              = 0 << 1, // Free block.
            GapPlug                = 1 << 1, // Used to mark free space that cannot be reclaimed due to fragmentation.
            ReadOnlyObject         = 2 << 1, // This object is stored in read-only memory.
            UnreclaimableObject    = 3 << 1, // This object is stored outside the garbage-collected heap.
            NormalObject           = 4 << 1, // Normal object.
            SpecialHandlerObject   = 5 << 1, // This object has a GC extension handler.
            AllocatedRawBytes      = 6 << 1, // Allocated bytes that have not been initialized yet
        }

        public enum ExtensionKinds : uint
        {
            Empty = 0,
            HashCode,
            SyncBlock,
        }

        //
        // State
        //

        [TS.WellKnownField( "ObjectHeader_MultiUseWord" )] public volatile int       MultiUseWord;
        [TS.WellKnownField( "ObjectHeader_VirtualTable" )] public          TS.VTable VirtualTable;

        //
        // Don't allow object creation, this is not a real class, it's more of a struct.
        //

        private ObjectHeader()
        {
        }

        //
        // Helper Methods
        //

#if CANONICAL_OBJECT_POINTERS
        public ObjectImpl Pack()
        {
            UIntPtr address = AddressMath.Increment(ToPointer(), HeaderSize);
            return ObjectImpl.FromPointer(address);
        }

        public static ObjectHeader Unpack(object obj)
        {
            UIntPtr address = AddressMath.Decrement(((ObjectImpl)obj).ToPointer(), HeaderSize);
            return CastAsObjectHeader(address);
        }
#else // CANONICAL_OBJECT_POINTERS
        [TS.GenerateUnsafeCast]
        public extern ObjectImpl Pack();

        [TS.GenerateUnsafeCast]
        public extern static ObjectHeader Unpack( object obj );
#endif // CANONICAL_OBJECT_POINTERS

        [TS.GenerateUnsafeCast]
        public extern UIntPtr ToPointer();

        [TS.GenerateUnsafeCast]
        public extern static ObjectHeader CastAsObjectHeader( UIntPtr ptr );

        [Inline]
        public unsafe UIntPtr GetNextObjectPointer()
        {
            return AddressMath.Increment( ToPointer(), this.TotalSize );
        }

        public static uint HeaderSize
        {
            [Inline]
            get
            {
                return (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(ObjectHeader));
            }
        }

        public uint ObjectSize
        {
            get
            {
                uint arrayLength = (uint)ArrayImpl.CastAsArray((Object)this.Pack()).Length;
                return ComputeObjectSize(this.VirtualTable, arrayLength);
            }
        }

        public uint TotalSize
        {
            get
            {
                uint size;

                if(this.GarbageCollectorStateWithoutMutableBits == GarbageCollectorFlags.AllocatedRawBytes)
                {
                    size = this.AllocatedRawBytesSize;
                }
                else
                {
                    size = HeaderSize + ObjectSize;
                }

                return size;
            }
        }

        public static uint ComputeObjectSize(TS.VTable vTable, uint arrayLength)
        {
            uint size = vTable.BaseSize + vTable.ElementSize * arrayLength;

            // Every object should have a payload
            if (size == 0)
            {
                size = 1;
            }

            return AddressMath.AlignToDWordBoundary(size);
        }

        [TS.WellKnownMethod("DebugGC_ObjectHeader_InsertPlug")]
        public unsafe void InsertPlug( uint size )
        {
            UIntPtr address = this.ToPointer();
            uint*   dst     = (uint*)address.ToPointer();
            var bytesLeft = size;

            while(bytesLeft >= sizeof(uint))
            {
                *dst++  = (uint)GarbageCollectorFlags.GapPlug;
                bytesLeft -= sizeof(uint);
            }
        }

        [Inline]
        public void InitializeAllocatedRawBytes( uint size )
        {
            this.MultiUseWord = (int)GarbageCollectorFlags.AllocatedRawBytes;
            this.AllocatedRawBytesSize = size;
        }

        //--//

        public void UpdateExtension( ExtensionKinds kind, int payload )
        {
            BugCheck.Assert( this.IsImmutable == false, BugCheck.StopCode.SyncBlockCorruption );

            while(true)
            {
                var  oldValue = this.MultiUseWord;
                uint newValue = ((uint)kind << ExtensionKindShift) | ((uint)payload << ExtensionPayloadShift) | ((uint)oldValue & GarbageCollectorMask);

                // CS0420: a reference to a volatile field will not be treated as volatile
#pragma warning disable 420
                var oldValue2 = System.Threading.Interlocked.CompareExchange( ref this.MultiUseWord, (int)newValue, oldValue );
#pragma warning restore 420

                if(oldValue2 == oldValue)
                {
                    break;
                }
            }
        }

#if REFCOUNT_STAT
        internal static int s_RefCountedObjectsAllocated = 0;
        internal static int s_RefCountedObjectsFreed = 0;
        internal static int s_AddRefCalled = 0;
        internal static int s_ReleaseCalled = 0;
        internal static int s_NoOpAddRefCalled = 0;
        internal static int s_NoOpReleaseCalled = 0;
        internal static int s_NonRCAddRefCalled = 0;
        internal static int s_NonRCReleaseCalled = 0;
        internal static int s_LoadAndAddRefCalled = 0;
        internal static int s_SwapCalled = 0;

        // Special Non-native version of AddReference for REFCOUNT_STAT
        [TS.WellKnownMethod( "ObjectHeader_AddReference" )]
        static public void AddReference( Object obj )
        {
            RecordAddReference( obj );

            if(obj != null)
            {
                ObjectHeader oh = ObjectHeader.Unpack( obj );

                if(oh.HasReferenceCount)
                {
                    oh.ModifyReferenceCount( /*delta*/1 );
                }
            }
        }
#else //REFCOUNT_STAT
        [TS.WellKnownMethod( "ObjectHeader_AddReference" )]
        [DllImport( "C" )]
        static public extern void AddReference( Object obj );
#endif //REFCOUNT_STAT

        [DllImport( "C" )]
        static public extern int ReleaseReferenceNative( Object obj );

        [TS.WellKnownMethod( "ObjectHeader_ReleaseReference" )]
        [TS.DisableAutomaticReferenceCounting]
        static public void ReleaseReference( Object obj )
        {
#if REFCOUNT_STAT
            RecordReleaseReference( obj );
#endif //REFCOUNT_STAT
            if(ReleaseReferenceNative( obj ) == 0)
            {
                ThreadImpl.CurrentThread.ReleaseReference.DeleteObject( ObjectHeader.Unpack( obj ) );
            }
        }

#if REFCOUNT_STAT
        public static void RecordAddReference( Object obj )
        {
            if(obj != null)
            {
                if(!ObjectHeader.Unpack( obj ).HasReferenceCount)
                {
                    s_NonRCAddRefCalled++;
                }

                s_AddRefCalled++;
            }
            else
            {
                s_NoOpAddRefCalled++;
            }
        }

        public static void RecordReleaseReference( Object obj )
        {
            if(obj != null)
            {
                s_ReleaseCalled++;

                if(!ObjectHeader.Unpack( obj ).HasReferenceCount)
                {
                    s_NonRCReleaseCalled++;
                }
            }
            else
            {
                s_NoOpReleaseCalled++;
            }
        }
#endif //REFCOUNT_STAT

        public static void DumpRefCountStat( bool reset )
        {
#if REFCOUNT_STAT
            var RefCountedObjectsAllocated = s_RefCountedObjectsAllocated;
            var RefCountedObjectsFreed = s_RefCountedObjectsFreed;
            var AddRefCalled = s_AddRefCalled;
            var ReleaseCalled = s_ReleaseCalled;
            var NoOpAddRefCalled = s_NoOpAddRefCalled;
            var NoOpReleaseCalled = s_NoOpReleaseCalled;
            var NonRCAddRefCalled = s_NonRCAddRefCalled;
            var NonRCReleaseCalled = s_NonRCReleaseCalled;
            var LoadAndAddRefCalled = s_LoadAndAddRefCalled;
            var SwapCalled = s_SwapCalled;

            BugCheck.Log( "RC objects alloced:%d freed:%d", RefCountedObjectsAllocated, RefCountedObjectsFreed );
            BugCheck.Log( "AddRefs:  %d (%d nop / %d nonRC)", AddRefCalled + NoOpAddRefCalled, NoOpAddRefCalled, NonRCAddRefCalled );
            BugCheck.Log( "Releases: %d (%d nop / %d nonRC)", ReleaseCalled + NoOpReleaseCalled, NoOpReleaseCalled, NonRCReleaseCalled );
            BugCheck.Log( "LoadAndAddReference: %d, Swap: %d", LoadAndAddRefCalled, SwapCalled );

            if (reset)
            {
                s_RefCountedObjectsAllocated = 0;
                s_RefCountedObjectsFreed = 0;
                s_AddRefCalled = 0;
                s_ReleaseCalled = 0;
                s_NoOpAddRefCalled = 0;
                s_NoOpReleaseCalled = 0;
                s_NonRCAddRefCalled = 0;
                s_NonRCReleaseCalled = 0;
                s_LoadAndAddRefCalled = 0;
                s_SwapCalled = 0;
            }
#endif //REFCOUNT_STAT
        }

        [Inline]
        internal bool DecrementReferenceCount()
        {
            int newMultiUseWord = ModifyReferenceCount( /*delta*/-1 );

            bool delete = ( newMultiUseWord & ReferenceCountMask ) == 0;

#if REFCOUNT_STAT
            s_ReleaseCalled++;

            if (delete)
            {
                s_RefCountedObjectsFreed++;
            }
#endif //REFCOUNT_STAT
            return delete;
        }

        [Inline]
        private int ModifyReferenceCount( int delta )
        {
#pragma warning disable 420 // a reference to a volatile field will not be treated as volatile
            var result = InterlockedImpl.InternalAdd( ref this.MultiUseWord, delta << ReferenceCountShift );
#pragma warning restore 420

#if DEBUG_REFCOUNT
            var ptr = ToPointer( );
            var refCount = ( result & ReferenceCountMask ) >> ReferenceCountShift;
            var isAlive = MemoryManager.Instance.IsObjectAlive( ptr );

            if(!isAlive)
            {
                BugCheck.Log( "Attempting to modifying ref count of a dead object!!" );
            }

            if(delta > 0)
            {
                BugCheck.Log( "AddRef (0x%x) %d +", (int)ptr, (int)refCount );
                BugCheck.Assert( refCount > 1, BugCheck.StopCode.HeapCorruptionDetected );
            }
            else
            {
                BugCheck.Log( "Release(0x%x) %d -", (int)ptr, (int)refCount );
                BugCheck.Assert( refCount >= 0, BugCheck.StopCode.HeapCorruptionDetected );
            }

            BugCheck.Assert( isAlive, BugCheck.StopCode.HeapCorruptionDetected );
#endif //DEBUG_REFCOUNT
            return result;
        }

        //
        // Access Methods
        //

        public unsafe GarbageCollectorFlags GarbageCollectorState
        {
            [Inline]
            get
            {
#pragma warning disable 420 // a reference to a volatile field will not be treated as volatile
                fixed(int* ptr = &this.MultiUseWord)
#pragma warning restore 420
                {
                    byte* flags = (byte*)ptr;

                    return (GarbageCollectorFlags)(uint)*flags;
                }
            }

            [Inline]
            set
            {
#pragma warning disable 420 // a reference to a volatile field will not be treated as volatile
                fixed(int* ptr = &this.MultiUseWord)
#pragma warning restore 420
                {
                    byte* flags = (byte*)ptr;

                    *flags = (byte)(uint)value;
                }
            }
        }
        
        public GarbageCollectorFlags GarbageCollectorStateWithoutMutableBits
        {
            [Inline]
            get
            {
                return (this.GarbageCollectorState & ~GarbageCollectorFlags.MutableMask);
            }
        }

        public ExtensionKinds ExtensionKind
        {
            [Inline]
            get
            {
                return (ExtensionKinds)((this.MultiUseWord & ExtensionKindMask) >> ExtensionKindShift);
            }
        }

        public bool IsImmutable
        {
            [Inline]
            get
            {
                return this.GarbageCollectorStateWithoutMutableBits == GarbageCollectorFlags.ReadOnlyObject;
            }
        }

        public int Payload
        {
            [Inline]
            get
            {
                return (int)(((uint)this.MultiUseWord & ExtensionPayloadMask) >> ExtensionPayloadShift);
            }
        }

        public bool HasReferenceCount
        {
            [Inline]
            get
            {
                return ( this.MultiUseWord & ReferenceCountMask ) != 0;
            }
        }

        internal unsafe uint AllocatedRawBytesSize
        {
            [Inline]
            get
            {
#pragma warning disable 420 // a reference to a volatile field will not be treated as volatile
                fixed (int* ptr = &this.MultiUseWord)
#pragma warning restore 420
                {
                    uint* size = (uint*)( ptr + 1 );

                    return *size;
                }
            }

            [Inline]
            private set
            {
#pragma warning disable 420 // a reference to a volatile field will not be treated as volatile
                fixed (int* ptr = &this.MultiUseWord)
#pragma warning restore 420
                {
                    uint* size = (uint*)( ptr + 1 );

                    *size = value;
                }
            }
        }

        //--//


        //
        // Extension Methods
        //

        [ExtendClass(typeof(TS.VTable), NoConstructors=true, ProcessAfter=typeof(TypeImpl))]
        class VTableImpl
        {

            [Inline]
            public static TS.VTable Get( object a )
            {
                ObjectImpl.NullCheck( a );

                ObjectHeader oh = ObjectHeader.Unpack( a );

                return oh.VirtualTable;
            }

            [Inline]
            public static TS.VTable GetFromTypeHandle( RuntimeTypeHandleImpl hnd )
            {
                return hnd.m_value;
            }
        }
    }
}
