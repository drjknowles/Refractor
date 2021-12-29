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
            var targetType = target.GetType();

            PropertyTestGenerator.ClassName = $"{targetType.Name}_PropertyGetterSetterTests";
            PropertyTestGenerator.ClassNameUnderTest = targetType.Name;

            foreach(var property in targetType.GetProperties())
            { 
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
