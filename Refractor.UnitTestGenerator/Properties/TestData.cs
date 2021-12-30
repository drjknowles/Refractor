namespace Refractor.UnitTestGenerator.Properties
{
    using System;

    public class TestData
    {
        /// <summary>
        /// Name of the property
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Type of the Property
        /// </summary>
        public Type PropertyType { get; set; }

        /// <summary>
        /// Name of the property type as appearing in the tests
        /// </summary>
        public string PropertyTypeName => PropertyType?.Name ?? "object";
    }
}
