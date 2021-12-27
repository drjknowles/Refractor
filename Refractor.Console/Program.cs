namespace Refractor.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reflect and refactor!");

            var testGen = new Refractor.UnitTestGenerator.Properties.PropertyTest();

            var demoObject = new Refractor.DemoProject.DemoClass();

            var t4 = testGen.GeneratePropertyTests(demoObject);

            Console.WriteLine(t4);
        }
    }
}
