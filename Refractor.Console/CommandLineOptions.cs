namespace Refractor.Console
{
    using System;
    using CommandLine;

    public class CommandLineOptions
    {
        [Option('p', "propertiesTest", Default = false, Required = false, HelpText = "Generate Tests for Getters and Setters in a Class.")]
        public bool GeneratePropertiesTest { get; set; }

        [Option('o', "output", Required = true, HelpText = "Name of the output file.")]
        public string OutputFileName { get; set; }

        [Option("overwrite", Required = false, HelpText = "Overwrite output file if exisiting.")]
        public bool OverwriteOutputFile { get; set; }
    }
}
