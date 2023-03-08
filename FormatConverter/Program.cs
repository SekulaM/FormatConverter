namespace FormatConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleArguments.GetConsoleArgs(args);
            Builder builder = new(ConsoleArguments.StorageInput, ConsoleArguments.OutputFormat, ConsoleArguments.StorageOutput);

            string fileContent = builder.InputStorage.ReadFromFile();
            string outputResult = builder.OutputFormat.ConvertToFormat(fileContent);
            builder.OutputStorage.WriteIntoFile(outputResult);
        } 
    }
}
