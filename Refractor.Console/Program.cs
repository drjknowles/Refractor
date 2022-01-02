namespace Refractor.Console
{
    using System;
    using CommandLine;
    using SimpleInjector;

    class Program
    {
        
        static readonly Container container;

        static Program()
        {
            // 1. Create a new Simple Injector container
            container = new Container();

            // 2. Configure the container (register)
                
            // 3. Verify your configuration
            container.Verify();
        }
        

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CommandLineOptions>(args).WithParsed(x =>
            {
                // Logic in here for development testing only
                Console.WriteLine("Reflect and refactor!");

                var testGen = new Refractor.UnitTestGenerator.Properties.PropertyTest();

                var demoObject = new Refractor.DemoProject.DemoClass();

                var t4 = testGen.GeneratePropertyTests(demoObject);

                Console.WriteLine(t4);
                System.IO.File.WriteAllText("../../../../Refractor.UnitTestGenerator.Tests/Properties/trialOutput.cs", t4);
            });
        }
    }
}
