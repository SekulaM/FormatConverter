using System;
using System.Collections.Generic;
using System.Linq;

namespace FormatConverter
{
    /// <summary>
    /// Class used for informing the user (loggs messages into the console)
    /// </summary>
    public static class ConsoleLog
    {
        /// <summary>
        /// Displays the arguments given by the user
        /// </summary>
        /// <param name="arguments"> User arguments </param>
        public static void LogConsoleArgs(Dictionary<string, string> arguments)
        {
            Console.WriteLine("Arguments: ");
            arguments.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
            Console.WriteLine();
        }

        /// <summary>
        /// Displays input and output formats
        /// </summary>
        /// <param name="inputFormat"> Format of the input file </param>
        /// <param name="outputFormat"> Format of the output file </param>
        public static void LogConvertingFormat(string inputFormat, string outputFormat)
        {
            Console.WriteLine($"Converting {inputFormat} to {outputFormat}");
        }

        /// <summary>
        /// Displays the path to the output file
        /// </summary>
        /// <param name="convertedFilePath"> Path to the converted (output) file </param>
        public static void LogConvertedFile(string convertedFilePath)
        {
            Console.WriteLine($"File converted to: {convertedFilePath}");
        }

        /// <summary>
        /// Displays no arguments message
        /// </summary>
        public static void LogNoArguments()
        {
            Console.WriteLine("No arguments given! Please provide values for all required arguments. Closing the application...");
        }

        /// <summary>
        /// Displays that not all arguments have a value
        /// </summary>
        public static void LogNotAllargumentsHaveValue()
        {
            Console.WriteLine("Not all arguments have a value! Please provide values for all required arguments. Closing the application...");
        }
    }
}
