namespace Refractor.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Logic in here for development testing only
            Console.WriteLine("Reflect and refactor!");

            var testGen = new Refractor.UnitTestGenerator.Properties.PropertyTest();

            var demoObject = new Refractor.DemoProject.DemoClass();

            var t4 = testGen.GeneratePropertyTests(demoObject);

            Console.WriteLine(t4);
            System.IO.File.WriteAllText("../../../../Refractor.UnitTestGenerator.Tests/Properties/trialOutput.cs", t4);
        }
    }
}
