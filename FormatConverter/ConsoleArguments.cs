using System;
using System.Collections.Generic;
using System.Linq;

namespace FormatConverter
{
    /// <summary>
    /// Represents the arguments from the console
    /// </summary>
    public static class ConsoleArguments
    {
        /// <summary>
        /// The original input file
        /// </summary>
        public static string InputFile { get; set; }

        /// <summary>
        /// The output file, result of the conversion
        /// </summary>
        public static string OutputFile  { get; set; }

        /// <summary>
        /// Format of the input file
        /// </summary>
        public static string InputFormat { get; set; }

        /// <summary>
        /// Desired format of the output file
        /// </summary>
        public static string OutputFormat { get; set; }

        /// <summary>
        /// Type of storage where the input file is located
        /// </summary>
        public static string StorageInput { get; set; }

        /// <summary>
        /// Type of storage where the output file should be saved
        /// </summary>
        public static string StorageOutput { get; set; }

        /// <summary>
        /// Gets the user args from the console
        /// </summary>
        /// <param name="args"> User arguments </param>
        public static void GetConsoleArgs(string[] args)
        {
            CheckArgsNotEmpty(args);

            Dictionary<string, string> arguments = new Dictionary<string, string>();

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i][..1] == "/" && (i + 1 ) < args.Length)
                    arguments[args[i][1..]] = args[++i];
            }

            if (arguments.TryGetValue(nameof(InputFile), out string inputFile))
                InputFile = inputFile;

            if (arguments.TryGetValue(nameof(OutputFile), out string outputFile))
                OutputFile = outputFile;

            if (arguments.TryGetValue(nameof(InputFormat), out string inputFormat))
                InputFormat = inputFormat;

            if (arguments.TryGetValue(nameof(OutputFormat), out string outputFormat))
                OutputFormat = outputFormat;

            if (arguments.TryGetValue(nameof(StorageInput), out string storageInput))
                StorageInput = storageInput;

            if (arguments.TryGetValue(nameof(StorageOutput), out string storageOutput))
                StorageOutput = storageOutput;

            CheckAllArgsHaveValues(args);    

            ConsoleLog.LogConsoleArgs(arguments);
        }

        /// <summary>
        /// Checks whether there are some arguments
        /// </summary>
        /// <param name="args"></param>
        private static void CheckArgsNotEmpty(string[] args)
        {
            if (args.Length == 0)
            {
                ConsoleLog.LogNoArguments();
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Checks whether all arguments have values
        /// </summary>
        /// <param name="args"></param>
        private static void CheckAllArgsHaveValues(string[] args) 
        {
            if(typeof(ConsoleArguments).GetProperties().Any(prop => prop.GetValue(typeof(ConsoleArguments)) == null))
            {
                ConsoleLog.LogNotAllargumentsHaveValue();
                Environment.Exit(0);
            }
        }
    }
}
