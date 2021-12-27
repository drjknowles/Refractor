namespace Refractor.UnitTestGenerator.Properties
{
	using System;
	using System.Collections.Generic;

	public partial class PropertyTestGenerator
	{
		public string TestNamespace { get; set; } = "TestNameSpace.Tests";

		public List<TestData> PropertyTestData { get; set; } = new List<TestData>();
    }
}
