////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#define TEST_EXCEPTIONS

using System;
using System.Reflection;
using Microsoft.Zelig.Test;

namespace Microsoft.Zelig.Test
{
    public class PropertiesTests : TestBase, ITestInterface
    {
        [SetUp]
        public InitializeResult Initialize()
        {
            Log.Comment("Adding set up for the tests");

            return InitializeResult.ReadyToGo;
        }

        [TearDown]
        public void CleanUp()
        {
            Log.Comment("Cleaning up after the tests");
        }
        
        public override TestResult Run(string[] args)
        {
            TestResult result = TestResult.Pass;

            string testName = "Properties";
            result |= Assert.CheckFailed(Properties003_Test(), testName, 3);
            result |= Assert.CheckFailed(Properties004_Test(), testName, 4);
            result |= Assert.CheckFailed(Properties005_Test(), testName, 5);
            result |= Assert.CheckFailed(Properties006_Test(), testName, 6);
            result |= Assert.CheckFailed(Properties007_Test(), testName, 7);
            result |= Assert.CheckFailed(Properties008_Test(), testName, 8);
            result |= Assert.CheckFailed(Properties009_Test(), testName, 9);
            result |= Assert.CheckFailed(Properties010_Test(), testName, 10);
            result |= Assert.CheckFailed(Properties011_Test(), testName, 11);
            result |= Assert.CheckFailed(Properties024_Test(), testName, 24);
            result |= Assert.CheckFailed(Properties025_Test(), testName, 25);
            result |= Assert.CheckFailed(Properties026_Test(), testName, 26);
            result |= Assert.CheckFailed(Properties027_Test(), testName, 27);
            result |= Assert.CheckFailed(Properties033_Test(), testName, 33);
            result |= Assert.CheckFailed(Properties034_Test(), testName, 34);
            result |= Assert.CheckFailed(Properties035_Test(), testName, 35);
            result |= Assert.CheckFailed(Properties036_Test(), testName, 36);
            result |= Assert.CheckFailed(Properties037_Test(), testName, 37);
            result |= Assert.CheckFailed(Properties038_Test(), testName, 38);
            result |= Assert.CheckFailed(Properties043_Test(), testName, 43);
            result |= Assert.CheckFailed(Properties046_Test(), testName, 46);
            result |= Assert.CheckFailed(Properties048_Test(), testName, 48);
            result |= Assert.CheckFailed(Properties050_Test(), testName, 50);
            result |= Assert.CheckFailed(Properties053_Test(), testName, 53);
            result |= Assert.CheckFailed(Properties054_Test(), testName, 54);
            result |= Assert.CheckFailed(Properties056_Test(), testName, 56);
            result |= Assert.CheckFailed(Properties058_Test(), testName, 58);
            result |= Assert.CheckFailed(Properties059_Test(), testName, 59);
            result |= Assert.CheckFailed(Properties060_Test(), testName, 60);
            result |= Assert.CheckFailed(Properties062_Test(), testName, 62);
            result |= Assert.CheckFailed(Properties068_Test(), testName, 68);
            result |= Assert.CheckFailed(Properties071_Test(), testName, 71);
            result |= Assert.CheckFailed(Properties072_Test(), testName, 72);
            result |= Assert.CheckFailed(Properties073_Test(), testName, 73);
            result |= Assert.CheckFailed(Properties074_Test(), testName, 74);
            result |= Assert.CheckFailed(Properties075_Test(), testName, 75);
            result |= Assert.CheckFailed(Properties078_Test(), testName, 78);
            result |= Assert.CheckFailed(Properties089_Test(), testName, 89);
            result |= Assert.CheckFailed(Properties090_Test(), testName, 90);
            result |= Assert.CheckFailed(Properties097_Test(), testName, 97);
            result |= Assert.CheckFailed(Properties109_Test(), testName, 109);
            result |= Assert.CheckFailed(Properties110_Test(), testName, 110);
            result |= Assert.CheckFailed(Properties121_Test(), testName, 121);
            result |= Assert.CheckFailed(Properties122_Test(), testName, 122);
            result |= Assert.CheckFailed(Properties123_Test(), testName, 123);
            result |= Assert.CheckFailed(Properties124_Test(), testName, 124);
            result |= Assert.CheckFailed(Properties125_Test(), testName, 125);
            result |= Assert.CheckFailed(Properties126_Test(), testName, 126);

            return result;
        }

        //Properties Test methods
        //The following test methods were ported from the folder 
        //current\test\cases\client\CLR\Conformance\10_classes\Properties
        //003,004,005,006,007,008,009,010,011,024,025,026,027,033,034,035,036,037,038,
        //043,046,048,050,053,054,056,058,059,060,062,068,071,072,073,074,075,078,089,
        //090,097,109,110,121,122,123,124,125,126
        //Tests 134-125 failed in the Baseline Doc, all others passed
        //All tests that were not ported were not present in the Baseline Doc

        //Test Case Calls 
        [TestMethod]
        public TestResult Properties003_Test()
        {
            
            Log.Comment("Section 10.6");
            Log.Comment("A property declaration may include set of");
            Log.Comment("attributes, a new modifier, a valid combination");
            Log.Comment("nof the four access modifiers, and a static modifier.");
            if (PropertiesTestClass003.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties004_Test()
        {
            Log.Comment("Section 10.6");
            Log.Comment("A property declaration may include set of");
            Log.Comment("attributes, a new modifier, a valid combination");
            Log.Comment("nof the four access modifiers, and a static modifier.");
            if (PropertiesTestClass004.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties005_Test()
        {
            Log.Comment("Section 10.6");
            Log.Comment("A property declaration may include set of");
            Log.Comment("attributes, a new modifier, a valid combination");
            Log.Comment("nof the four access modifiers, and a static modifier.");
            if (PropertiesTestClass005.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties006_Test()
        {
            Log.Comment("Section 10.6");
            Log.Comment("A property declaration may include set of");
            Log.Comment("attributes, a new modifier, a valid combination");
            Log.Comment("nof the four access modifiers, and a static modifier.");
            if (PropertiesTestClass006.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties007_Test()
        {
            Log.Comment("Section 10.6");
            Log.Comment("A property declaration may include set of");
            Log.Comment("attributes, a new modifier, a valid combination");
            Log.Comment("nof the four access modifiers, and a static modifier.");
            if (PropertiesTestClass007.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties008_Test()
        {
            Log.Comment("Section 10.6");
            Log.Comment("A property declaration may include set of");
            Log.Comment("attributes, a new modifier, a valid combination");
            Log.Comment("nof the four access modifiers, and a static modifier.");
            if (PropertiesTestClass008.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties009_Test()
        {
            Log.Comment("Section 10.6");
            Log.Comment("A property declaration may include set of");
            Log.Comment("attributes, a new modifier, a valid combination");
            Log.Comment("nof the four access modifiers, and a static modifier.");
            if (PropertiesTestClass009.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties010_Test()
        {
            Log.Comment("Section 10.6");
            Log.Comment("A property declaration may include set of");
            Log.Comment("attributes, a new modifier, a valid combination");
            Log.Comment("nof the four access modifiers, and a static modifier.");
            if (PropertiesTestClass010.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties011_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("The type of a property declaration specifies");
            Log.Comment("the type of the property introduced by the");
            Log.Comment("declaration, and the member-name specifies");
            Log.Comment("the name of the property.  Unless the property");
            Log.Comment("is an explicit interface member implementation,");
            Log.Comment("the member name is simply an identifier.  For an");
            Log.Comment("explicit interface member implementation, the");
            Log.Comment("member name consists of an interface-type followed");
            Log.Comment("by a . and an identifier.");
            Log.Comment("This is currently an expected fail, but is resolved in 3.0 see Bug  16341 for details");
            if (PropertiesTestClass011.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties024_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("An instance property is associated with");
            Log.Comment("a given instance of a class, and this instance");
            Log.Comment("can be accessed as this in the accessors of");
            Log.Comment("the property.");
            if (PropertiesTestClass024.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties025_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("An instance property is associated with");
            Log.Comment("a given instance of a class, and this instance");
            Log.Comment("can be accessed as this in the accessors of");
            Log.Comment("the property.");
            if (PropertiesTestClass025.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties026_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("When a property is referenced in a member-access");
            Log.Comment("of the form E.M, if M is a static property, E must");
            Log.Comment("denote a type, and if M is an instance property,");
            Log.Comment("E must denote an instance.");
            if (PropertiesTestClass026.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties027_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("When a property is referenced in a member-access");
            Log.Comment("of the form E.M, if M is a static property, E must");
            Log.Comment("denote a type, and if M is an instance property,");
            Log.Comment("E must denote an instance.");
            if (PropertiesTestClass027.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties033_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("The accessor declarations consist of a ");
            Log.Comment("get-accessor-declaration, a set-accessor");
            Log.Comment("declaration, or both.");
            if (PropertiesTestClass033.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties034_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("The accessor declarations consist of a ");
            Log.Comment("get-accessor-declaration, a set-accessor");
            Log.Comment("declaration, or both.");
            if (PropertiesTestClass034.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties035_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("The accessor declarations consist of a ");
            Log.Comment("get-accessor-declaration, a set-accessor");
            Log.Comment("declaration, or both.");
            if (PropertiesTestClass035.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties036_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass036.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties037_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass037.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties038_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass038.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties043_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass043.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties046_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass046.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties048_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass048.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties050_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass050.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties053_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
#if TEST_EXCEPTIONS
            if (PropertiesTestClass053.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
#else
            return TestResult.Skip;
#endif
        }
        [TestMethod]
        public TestResult Properties054_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
#if TEST_EXCEPTIONS
            if (PropertiesTestClass054.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
#else
            return TestResult.Skip;
#endif
        }
        [TestMethod]
        public TestResult Properties056_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass056.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties058_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass058.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties059_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass059.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties060_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass060.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties062_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass062.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties068_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass068.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties071_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass071.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties072_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass072.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties073_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass073.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties074_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass074.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties075_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass075.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties078_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass078.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties089_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass089.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties090_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass090.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties097_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass097.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties109_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass109.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties110_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass110.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties121_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass121.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties122_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass122.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties123_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            //Log.Comment("This test is an expected fail");
            if (PropertiesTestClass123.testMethod())
            {
                //return TestResult.Fail;
                return TestResult.Pass;
            }
            //return TestResult.Pass;
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties124_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            //Log.Comment("This test is an expected fail");
            if (PropertiesTestClass124.testMethod())
            {
                //return TestResult.Fail;
                return TestResult.Pass;
            }
            //return TestResult.Pass;
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties125_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass125.testMethod())
            {
                return TestResult.Pass;
            }
            return TestResult.Fail;
        }
        [TestMethod]
        public TestResult Properties126_Test()
        {
            Log.Comment("Section 10.6 ");
            Log.Comment("Each accessor declaration consists of an");
            Log.Comment("optional accessor-modifier, followed by the");
            Log.Comment("keyword get or set, followed by an accessor");
            if (PropertiesTestClass126.testMethod())
            {
                return TestResult.Fail;
            }
            return TestResult.Pass;
        }

        //Compiled Test Cases 
        class PropertiesTestClass003 {
	        int intI = 0;
	        int MyProp {
		        get {
			        return intI;
		        }
		        set {
			        intI = value;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass003 test = new PropertiesTestClass003();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        class PropertiesTestClass004_Base {
	        public int MyProp {
		        get {
			        return 1;
		        }
	        }
        }	
        class PropertiesTestClass004 : PropertiesTestClass004_Base {
	        int intI = 0;
	        new int MyProp {
		        get {
			        return intI;
		        }
		        set {
			        intI = value;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass004 test = new PropertiesTestClass004();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        class PropertiesTestClass005 {
	        int intI = 0;
	        public int MyProp {
		        get {
			        return intI;
		        }
		        set {
			        intI = value;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass005 test = new PropertiesTestClass005();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        class PropertiesTestClass006 {
	        int intI = 0;
	        protected int MyProp {
		        get {
			        return intI;
		        }
		        set {
			        intI = value;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass006 test = new PropertiesTestClass006();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        class PropertiesTestClass007 {
	        int intI = 0;
	        internal int MyProp {
		        get {
			        return intI;
		        }
		        set {
			        intI = value;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass007 test = new PropertiesTestClass007();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        class PropertiesTestClass008 {
	        int intI = 0;
	        private int MyProp {
		        get {
			        return intI;
		        }
		        set {
			        intI = value;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass008 test = new PropertiesTestClass008();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        class PropertiesTestClass009 {
	        int intI = 0;
	        protected internal int MyProp {
		        get {
			        return intI;
		        }
		        set {
			        intI = value;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass009 test = new PropertiesTestClass009();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        class PropertiesTestClass010 {
	        static int intI = 0;
	        static int MyProp {
		        get {
			        return intI;
		        }
		        set {
			        intI = value;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass010.MyProp = 2;
		        if (PropertiesTestClass010.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        interface PropertiesTestClass011_Interface {
	        int MyProp {
		        get;
		        set;
	        }
        }
        class PropertiesTestClass011 : PropertiesTestClass011_Interface {
	        static int intI = 0;
	        int PropertiesTestClass011_Interface.MyProp {
		        get {
			        return intI;
		        }
		        set {
			        intI = value;
		        }
	        }
	        public static bool testMethod() 
            {
                try
                {
                    PropertiesTestClass011 MC = new PropertiesTestClass011();
                    ((PropertiesTestClass011_Interface)MC).MyProp = 2;
                    if (((PropertiesTestClass011_Interface)MC).MyProp == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch 
                {
                    return false;
                }
	        }
        }
        public class PropertiesTestClass024 {
	        public int intI = 2;
	        public int MyProp {
		        get {
			        return this.intI;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass024 test = new PropertiesTestClass024();
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }		
	        }
        }
        public class PropertiesTestClass025 {
	        public int intI = 1;
	        public int MyProp {
		        set {
			        this.intI = value;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass025 test = new PropertiesTestClass025();
		        test.MyProp = 2;
		        if (test.intI == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }		
	        }
        }
        public class PropertiesTestClass026 {
	        public int intI = 1;
	        public int MyProp {
		        set {
			        this.intI = value;
		        }
		        get {
			        return intI;
		        }
	        }
	        public int GetProp() {
		        return MyProp;
	        }
	        public void SetProp(int intJ) {
		        MyProp = intJ;
	        }
	        public static bool testMethod() {
		        PropertiesTestClass026 test = new PropertiesTestClass026();
		        test.SetProp(3);
		        if (test.GetProp() == 3) {
			        return true;
		        }
		        else {
			        return false;
		        }		
	        }
        }
        public class PropertiesTestClass027 {
	        public static int intI = 1;
	        public static int MyProp {
		        set {
			        intI = value;
		        }
		        get {
			        return intI;
		        }
	        }
	        public static int GetProp() {
		        return MyProp;
	        }
	        public static void SetProp(int intJ) {
		        MyProp = intJ;
	        }
	        public static bool testMethod() {
		        PropertiesTestClass027.SetProp(3);
		        if (PropertiesTestClass027.GetProp() == 3) {
			        return true;
		        }
		        else {
			        return false;
		        }		
	        }
        }
        public class PropertiesTestClass033 {
	        public int MyProp {
		        get {
			        return 2;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass033 test = new PropertiesTestClass033();
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }	
	        }
        }
        public class PropertiesTestClass034 {
	        public int intI = 0;
	        public int MyProp {
		        set {
			        intI = value;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass034 test = new PropertiesTestClass034();
		        test.MyProp = 2;
		        if (test.intI == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }	
	        }
        }
        public class PropertiesTestClass035 {
	        public int intI = 0;
	        public int MyProp {
		        set {
			        intI = value;
		        }
		        get {
			        return intI;
		        }		
	        }
	        public static bool testMethod() {
		        PropertiesTestClass035 test = new PropertiesTestClass035();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }	
	        }
        }
        public class PropertiesTestClass036 {
	        int intI = 0;
	        public virtual int MyProp {
		        set {
			        intI = value;
		        }
		        get {
			        return intI;
		        }		
	        }
	        public static bool testMethod() {
		        PropertiesTestClass036 test = new PropertiesTestClass036();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }	
	        }
        }
        public class PropertiesTestClass037_Base {
	        public virtual int MyProp {
		        set {
		        }
		        get {
			        return -1;
		        }		
	        }
        }
        public class PropertiesTestClass037 : PropertiesTestClass037_Base {
	        int intI = 0;
	        public override int MyProp {
		        set {
			        intI = value;
		        }
		        get {
			        return intI;
		        }		
	        }
	        public static bool testMethod() {
		        PropertiesTestClass037_Base test = new PropertiesTestClass037();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }	
	        }
        }
        public abstract class PropertiesTestClass038_Base {
	        public abstract int MyProp {
		        set;
		        get;		
	        }
        }
        public class PropertiesTestClass038 : PropertiesTestClass038_Base {
	        int intI = 0;
	        public override int MyProp {
		        set {
			        intI = value;
		        }
		        get {
			        return intI;
		        }		
	        }
	        public static bool testMethod() {
		        PropertiesTestClass038_Base test = new PropertiesTestClass038();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }	
	        }
        }
        public class PropertiesTestClass043 {
	        public int TestInt = 1;
	        public int MyProp {
		        get {
			        TestInt = 2;
			        return -1;
		        }
		        set {
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass043 test = new PropertiesTestClass043();
		        test.MyProp = 2;
		        if (test.TestInt == 1) {
			        return true;
		        }	
		        else {
			        return false;
		        }
	        }
        }
        public class PropertiesTestClass046 {
	        public int MyProp {
		        get {
			        short s = 3;
			        return s;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass046 test = new PropertiesTestClass046();
		        if (test.MyProp == 3) {
			        return true;
		        }
		        else {
			        return false;
		        }		
	        }
        }
        public class PropertiesTestClass048_Sub {
	        public int intI = 2;
	        public static implicit operator int(PropertiesTestClass048_Sub t) {
		        return t.intI;
	        }

        }
        public class PropertiesTestClass048 {
	        public int MyProp {
		        get {
			        PropertiesTestClass048_Sub test = new PropertiesTestClass048_Sub();
			        return test;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass048 MC = new PropertiesTestClass048();
		        if (MC.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        public class PropertiesTestClass050_Sub {
	        public int intI = 2;
	        public static implicit operator int(PropertiesTestClass050_Sub t) {
		        return t.intI;
	        }

        }
        public class PropertiesTestClass050 {
	        public bool b = true;
	        public int MyProp {
		        get {
			        if (b == true) {
				        PropertiesTestClass050_Sub test = new PropertiesTestClass050_Sub();
				        return test;
			        }
			        else {
				        return 3;
			        }
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass050 MC = new PropertiesTestClass050();
		        PropertiesTestClass050 MC2 = new PropertiesTestClass050();
		        MC.b = true;
		        MC2.b = false;
		        if ((MC.MyProp == 2) && (MC2.MyProp == 3)) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        public class PropertiesTestClass053 {
	        public int MyProp {
		        get {
			        throw new System.Exception();		
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass053 test = new PropertiesTestClass053();
		        try {
			        int intJ = test.MyProp;
		        }
		        catch (System.Exception) {
			        return true;
		        }
		        return false;			
	        }
        }
        public class PropertiesTestClass054 {
	        public bool b = true;
	        public int MyProp {
		        get {
			        if (b == true) {
				        return 1;
			        }
			        else {
				        throw new System.Exception();
			        }		
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass054 MC = new PropertiesTestClass054();
		        PropertiesTestClass054 MC2 = new PropertiesTestClass054();
		        MC.b = true;
		        MC2.b = false;

		        if (MC.MyProp != 1) {
			        return false;
		        }

		        try {
			        int intJ = MC2.MyProp;
		        }
		        catch (System.Exception) {
			        return true;
		        }
		        return false;
	        }
        }
        public class PropertiesTestClass056 {
	        public int intI = 2;
	        public int MyProp {
		        set {}
		        get {
			        intI = 3;
			        return 1;		
		        }

	        }
	        public static bool testMethod() {
		        PropertiesTestClass056 test = new PropertiesTestClass056();
		        test.MyProp = 4;
		        if (test.intI == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        public class PropertiesTestClass058 {
	        public int intI = 2;
	        public int MyProp {
		        set {
			        return;
			        intI = 3;			
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass058 test = new PropertiesTestClass058();
		        test.MyProp = 4;
		        if (test.intI == 2) {
			        return true;
		        }
		        else {
			        return false;	
		        }
	        }
        }
        public class PropertiesTestClass059 {
	        public int intI = 2;
	        public int MyProp {
		        set {
			        intI = value;
			        return;			
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass059 test = new PropertiesTestClass059();
		        test.MyProp = 4;
		        if (test.intI == 4) {
			        return true;
		        }
		        else {
			        return false;	
		        }
	        }
        }
        public class PropertiesTestClass060 {
	        bool b = true;
	        public int intI = 2;
	        public int MyProp {
		        set {
			        if (b == true) {
				        intI = value;
				        return;			
			        }
			        else {
				        intI = value + 1;
				        return;
			        }
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass060 test = new PropertiesTestClass060();
		        PropertiesTestClass060 test2 = new PropertiesTestClass060();
		        test.b = true;
		        test2.b = false;
		        test.MyProp = 4;
		        test2.MyProp = 4;
		        if ((test.intI == 4) && (test2.intI == 5)) {
			        return true;
		        }
		        else {
			        return false;	
		        }
	        }
        }
        public class PropertiesTestClass062 {
	        int value;
	        public int MyProp {
		        set {
			        this.value = 2;
			        value = 3;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass062 test = new PropertiesTestClass062();
		        test.MyProp = 1;
		        if (test.value == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        public class PropertiesTestClass068_Base {
	        public int intTest;	
	        public int MyProp {
		        get {
			        return intTest;
		        }
		        set {
			        intTest = value;
		        }
	        }
        }
        public class PropertiesTestClass068 : PropertiesTestClass068_Base {
	        new public int MyProp {
		        get {
			        return intTest + 1;
		        }
		        set {
			        intTest = value + 1;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass068 test = new PropertiesTestClass068();
		        test.MyProp = 2;
		        if (test.MyProp == 4) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        public class PropertiesTestClass071_Base {

	        public int MyProp {
		        get {
			        return 1;
		        }
	        }
        }
        public class PropertiesTestClass071 : PropertiesTestClass071_Base {
	        public int MyProp {
		        set {}
	        }
	        public static bool testMethod() {
		        PropertiesTestClass071 test = new PropertiesTestClass071();
		        int intJ = ((PropertiesTestClass071_Base)test).MyProp;
		        if (intJ == 1) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        public class PropertiesTestClass072_Base {

	        public int intI;
	        public int MyProp {
		        set{intI = value;}
	        }
        }
        public class PropertiesTestClass072 : PropertiesTestClass072_Base {
	        new public int MyProp {
		        get {return 1;}
	        }
	        public static bool testMethod() {
		        PropertiesTestClass072 test = new PropertiesTestClass072();
		        ((PropertiesTestClass072_Base)test).MyProp = 2;
		        if (test.intI == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        public class PropertiesTestClass073_Base {

	        public int MyProp {
		        get {
			        return 1;
		        }
	        }
        }
        public class PropertiesTestClass073 : PropertiesTestClass073_Base {
	        new public int MyProp {
		        get {return 2;}
	        }
	        public static bool testMethod() {
		        PropertiesTestClass073 test = new PropertiesTestClass073();
		        int intJ = ((PropertiesTestClass073_Base)test).MyProp;
		        if (intJ == 1) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        public class PropertiesTestClass074_Base {

	        public int intI;
	        public int MyProp {
		        set{intI = value;}
	        }
        }
        public class PropertiesTestClass074 : PropertiesTestClass074_Base {
	        new public int MyProp {
		        set{intI = value + 1;}
	        }
	        public static bool testMethod() {
		        PropertiesTestClass074 test = new PropertiesTestClass074();
		        ((PropertiesTestClass074_Base)test).MyProp = 2;
		        if (test.intI == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        public class PropertiesTestClass075 {
	        int intI = 0;
	        public virtual int MyProp {
		        get {return intI;}
		        set {intI = value;}
	        }
	        public static bool testMethod() {
		        PropertiesTestClass075 test = new PropertiesTestClass075();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        public abstract class PropertiesTestClass078_Sub {
	        public int intI = 0;
	        public abstract int MyProp {
		        get;
		        set;
	        }
        }
        public class PropertiesTestClass078 : PropertiesTestClass078_Sub {
	        public override int MyProp {
		        get {return intI;}
		        set {intI = value;}
	        }
	        public static bool testMethod() {
		        PropertiesTestClass078_Sub test = new PropertiesTestClass078();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        public class PropertiesTestClass089_Base {
	        public int intI;
	        public virtual int MyProp {
		        set {intI = value;}
		        get {return intI;}
	        }
        }
        public class PropertiesTestClass089 : PropertiesTestClass089_Base {
	        public override int MyProp {
		        get {return intI + 1;}
	        }
	        public static bool testMethod() {
		        PropertiesTestClass089_Base test = new PropertiesTestClass089();
		        test.MyProp = 2;
		        if (test.MyProp == 3) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        public class PropertiesTestClass090_Base {
	        public int intI;
	        public virtual int MyProp {
		        set {intI = value;}
		        get {return intI;}
	        }
        }
        public class PropertiesTestClass090 : PropertiesTestClass090_Base {
	        public override int MyProp {
		        set {intI = value - 1;}
	        }
	        public static bool testMethod() {
		        PropertiesTestClass090_Base test = new PropertiesTestClass090();
		        test.MyProp = 2;
		        if (test.MyProp == 1) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        class PropertiesTestClass097 {
	        int intI = 0;
	        int MyProp {
		        set {
			        intI = value;
		        }
		        get {
			        return intI;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass097 test = new PropertiesTestClass097();
		        test.MyProp = 2;
		        if (test.MyProp == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        class PropertiesTestClass109_Base {
	        public virtual int foo {
		        get {
			        return 1;
		        }
	        }	
        }
        class PropertiesTestClass109_Derived : PropertiesTestClass109_Base {
	        private int get_foo() {
		        return 1;
	        }	
        }
        class PropertiesTestClass109 : PropertiesTestClass109_Derived {
	        public override int foo {
		        get {
			        return 2;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass109_Base MB = new PropertiesTestClass109();
		        if (MB.foo == 2) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        class PropertiesTestClass110_Base {
	        public int intI;
	        public virtual int foo {
		        set {
			        intI = 1;
		        }
	        }	
        }
        class PropertiesTestClass110_Derived : PropertiesTestClass110_Base {
	        private void set_foo(int value) {
		        intI = 2;
	        }	
        }
        class PropertiesTestClass110 : PropertiesTestClass110_Derived {
	        public override int foo {
		        set {
			        intI = 3;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass110_Base MB = new PropertiesTestClass110();
		        MB.foo = 3;
		        if (MB.intI == 3) {
			        return true;
		        }
		        else {
			        return false;
		        }
	        }
        }
        class PropertiesTestClass121_Base 
        {
	        public virtual int MyProp
	        {
		        get {
			        return 1;
		        }
	        }
        }
        class PropertiesTestClass121 : PropertiesTestClass121_Base {
	        public override int MyProp {
		        get {
			        return 2;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass121_Base MC = new PropertiesTestClass121();
		        if (MC.MyProp == 2)
		        {
			        return true;
		        }
		        else
		        { 
			        return false;
		        }
	        }
        }
        class PropertiesTestClass122_Base 
        {
	        public int myInt;
	        public virtual int MyProp
	        {
		        set {
			        myInt = 1;
		        }
	        }
        }
        class PropertiesTestClass122 : PropertiesTestClass122_Base {
	        public override int MyProp {
		        set {
			        myInt = 2;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass122_Base MC = new PropertiesTestClass122();
		        MC.MyProp = 0;
		        if (MC.myInt == 2)
		        {
			        return true;
		        }
		        else
		        { 
			        return false;
		        }
	        }
        }
        class PropertiesTestClass123_Base 
        {
	        public virtual int MyProp
	        {
		        get {
			        return 1;
		        }
	        }
        }
        class PropertiesTestClass123 : PropertiesTestClass123_Base {
	        public new int MyProp {
		        get {
			        return 2;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass123_Base MC = new PropertiesTestClass123();
		        if (MC.MyProp == 1)
		        {
			        return true;
		        }
		        else
		        { 
			        return false;
		        }
	        }
        }
        class PropertiesTestClass124_Base 
        {
	        public int myInt;
	        public virtual int MyProp
	        {
		        set {
			        myInt = 1;
		        }
	        }
        }
        class PropertiesTestClass124 : PropertiesTestClass124_Base {
	        public new int MyProp {
		        set {
			        myInt = 2;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass124_Base MC = new PropertiesTestClass124();
		        MC.MyProp = 0;
		        if (MC.myInt == 1)
		        {
			        return true;
		        }
		        else
		        { 
			        return false;
		        }
	        }
        }
        class PropertiesTestClass125_Base 
        {
	        public int intI = 0;
	        public virtual int MyProp
	        {
		        get {
			        return -1;
		        }
		        set {
			        intI = -1;
		        } 

	        }
        }
        class PropertiesTestClass125 : PropertiesTestClass125_Base {
	        public override int MyProp {
		        get {
			        return intI;
		        }
		        set
		        {
			        intI = value;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass125_Base MC = new PropertiesTestClass125();
		        MC.MyProp = 4;
		        if (MC.MyProp == 4)
		        {
			        return true;
		        }
		        else
		        { 
			        return false;
		        }
	        }
        }
        class PropertiesTestClass126_Base 
        {
	        public int intI = 0;
	        public virtual int MyProp
	        {
		        get {
			        return intI;
		        }
		        set {
			        intI = value;
		        } 

	        }
        }
        class PropertiesTestClass126 : PropertiesTestClass126_Base {
	        public new int MyProp {
		        get {
			        return -1;
		        }
		        set
		        {
			        intI = -1;
		        }
	        }
	        public static bool testMethod() {
		        PropertiesTestClass126_Base MC = new PropertiesTestClass126();
		        MC.MyProp = 4;
		        if (MC.MyProp == -1)
		        {
			        return true;
		        }
		        else
		        { 
			        return false;
		        }
	        }
        }




    }
}

