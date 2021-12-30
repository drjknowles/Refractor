namespace Refractor.UnitTestGenerator.Properties
{
	using System;
	using System.Collections.Generic;

	public partial class PropertyTestGenerator
	{
		/// <summary>
        /// Namespace to conatin the Unit Test Classes
        /// </summary>
		public string TestNamespace { get; set; } = "Refractor.UnitTestGenerator.Tests.Properties";

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

        protected string[] GetTestValuesForType(Type type)
        {
            if(type == typeof(string))
            {
                return new[] { "\"TestString_1234\"" };
            }
            else if (type == typeof(int))
            {
                return new[] { "0", Int32.MaxValue.ToString(), Int32.MinValue.ToString() };
            }
            else if (type == typeof(bool))
            {
                return new[] { "true", "false" };
            }
            else if (type == typeof(float))
            {
                return new[] { "0f", float.MinValue.ToString(), float.MaxValue.ToString() };
            }
            else if (type == typeof(double))
            {
                return new[] { "3.67890d" };
            }
            return new[] { "default" };
        }
    }
}
