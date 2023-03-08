using FormatConverter;

namespace FormatConverterTests
{
    [TestClass]
    public class ConsoleArgumentsTests
    {
        /// <summary>
        /// Gets valid arguments and expects valid output
        /// </summary>
        [TestMethod]
        [DataRow(new string[] {"/InputFile", "testInput.xml", "/OutputFile", "testOutput.json", "/InputFormat", "JSON",
                "/OutputFormat", "XML", "/StorageInput", "FileSystem", "/StorageOutput", "FileSystem"})]
        public void GetConsoleArgs_ValidArgs_ProperArgsValues(string[] validArgs)
        {
            string[] expectedOutput = new string[] { "testInput.xml", "testOutput.json", "JSON", "XML", "FileSystem", "FileSystem" };

            ConsoleArguments.GetConsoleArgs(validArgs);

            CollectionAssert.AreEqual(new string[]
            {
              ConsoleArguments.InputFile, ConsoleArguments.OutputFile, ConsoleArguments.InputFormat,
              ConsoleArguments.OutputFormat, ConsoleArguments.StorageInput, ConsoleArguments.StorageOutput
            }, expectedOutput);
        }
    }
}