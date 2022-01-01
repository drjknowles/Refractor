namespace Refractor.UnitTestGenerator.Tests.Properties {

    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public partial class DemoClass_PropertyGetterSetterTests {
    
    private DemoClass classUnderTest;

    [TestInitialize]
    public void TestInitialize() {
    
        // Arrannge
        classUnderTest = new DemoClass();
    
    }
    
    [TestCleanup]
    public void TestCleanup() {
    
        // Clear up after tests
        classUnderTest = default;
    
    }
    
    [DataRow("TestString_1234", "TestString_1234")]
        [DataTestMethod]
    public void DemoClass_PropertyGetterSetterTests_TestString_GetAndSet(String input, String expected) {
        
        // Act
        classUnderTest.TestString = input;
        
        // Assert
        Assert.AreEqual(expected, classUnderTest.TestString);
    }
    
    [DataRow(0, 0)]
    [DataRow(2147483647, 2147483647)]
    [DataRow(-2147483648, -2147483648)]
        [DataTestMethod]
    public void DemoClass_PropertyGetterSetterTests_TestInteger_GetAndSet(Int32 input, Int32 expected) {
        
        // Act
        classUnderTest.TestInteger = input;
        
        // Assert
        Assert.AreEqual(expected, classUnderTest.TestInteger);
    }
    
    [DataRow(3.67890d, 3.67890d)]
        [DataTestMethod]
    public void DemoClass_PropertyGetterSetterTests_TestDouble_GetAndSet(Double input, Double expected) {
        
        // Act
        classUnderTest.TestDouble = input;
        
        // Assert
        Assert.AreEqual(expected, classUnderTest.TestDouble);
    }
    
    [DataRow(0f, 0f)]
    [DataRow(-3.4028235E+38, -3.4028235E+38)]
    [DataRow(3.4028235E+38, 3.4028235E+38)]
        [DataTestMethod]
    public void DemoClass_PropertyGetterSetterTests_TestFloat_GetAndSet(Single input, Single expected) {
        
        // Act
        classUnderTest.TestFloat = input;
        
        // Assert
        Assert.AreEqual(expected, classUnderTest.TestFloat);
    }
    
    [DataRow(true, true)]
    [DataRow(false, false)]
        [DataTestMethod]
    public void DemoClass_PropertyGetterSetterTests_TestBool_GetAndSet(Boolean input, Boolean expected) {
        
        // Act
        classUnderTest.TestBool = input;
        
        // Assert
        Assert.AreEqual(expected, classUnderTest.TestBool);
    }
    
        
    } // End of class DemoClass_PropertyGetterSetterTests

} // End of namespace Refractor.UnitTestGenerator.Tests.Properties
