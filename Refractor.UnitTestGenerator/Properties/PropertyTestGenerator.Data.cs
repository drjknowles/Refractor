namespace Refractor.UnitTestGenerator.Properties
{
	using System;
	using System.Collections.Generic;

	public partial class PropertyTestGenerator
	{
		/// <summary>
        /// Namespace to conatin the Unit Test Classes
        /// </summary>
		public string TestNamespace { get; set; } = "TestNameSpace.Tests";

		/// <summary>
        /// Name of the class being generated to contain the tests
        /// </summary>
		public string ClassName { get; set; }

        /// <summary>
        /// Name of the class being tested
        /// </summary>
        public string ClassNameUnderTest { get; set; }

        /// <summary>
        /// Data of the properties to be tested
        /// </summary>
        public List<TestData> PropertyTestData { get; set; } = new List<TestData>();

        protected string GetTestValueForType(Type type)
        {
            if(type == typeof(string))
            {
                return "TestString_1234";
            }
            else if (type == typeof(int))
            {
                return "345";
            }
            else if (type == typeof(bool))
            {
                return "true";
            }
            else if (type == typeof(float))
            {
                return "5.9875f";
            }
            else if (type == typeof(double))
            {
                return "3.67890d";
            }
            return "default";
        }
    }
}
