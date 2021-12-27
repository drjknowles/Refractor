namespace Refractor.UnitTestGenerator.Tests.Properties
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Refractor.UnitTestGenerator.Properties;

    [TestClass]
    public class PropertyTestGeneratorTests
    {
        private DemoClass demoClass;
        private PropertyTest propertyTest;


        [TestInitialize]
        public void TestInitialize()
        {
            // Arrange
            demoClass = new DemoClass();
            propertyTest = new PropertyTest();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            demoClass = default;
            propertyTest = default;
        }

        [DataRow("TestInteger", typeof(int))]
        [DataRow("TestDouble", typeof(double))]
        [DataRow("TestFloat", typeof(float))]
        [DataRow("TestBool", typeof(bool))]
        [DataRow("TestString", typeof(string))]
        [DataTestMethod]
        public void TestDataPopulatedCorrect(string propertyName, Type type)
        {
            // Act
            propertyTest.GeneratePropertyTests(demoClass);

            // Assert
            var actual = propertyTest.PropertyTestGenerator.PropertyTestData
                .Where(x => x.PropertyName == propertyName && x.PropertyType == type).ToList();

            Assert.AreEqual(1, actual.Count);
        }
    }
}
