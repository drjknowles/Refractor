namespace Refractor.UnitTestGenerator.Properties
{
    using System;
    using System.Reflection;

    public class PropertyTest
    {
       public PropertyTestGenerator PropertyTestGenerator { get; set; }

        public PropertyTest()
        {
            PropertyTestGenerator = new PropertyTestGenerator();
        }

        public string GeneratePropertyTests<T>(T target)
        {
            foreach(var property in target.GetType().GetProperties())
            {
                Console.WriteLine($"{property.Name} of type {property.PropertyType}");

                PropertyTestGenerator.PropertyTestData.Add(new TestData
                {
                    PropertyName = property.Name,
                    PropertyType = property.PropertyType
                });
            }

            return PropertyTestGenerator.TransformText();
        }
    }
}
