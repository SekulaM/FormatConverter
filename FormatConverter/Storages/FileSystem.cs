using System.IO;
using System.Text;

namespace FormatConverter.Storages
{
    /// <summary>
    /// File storage of type file system
    /// </summary>
    public class FileSystem : IStorage
    {
        /// <inheritdoc/>
        public string ReadFromFile()
        {
            string content;
            using (StreamReader streamReader = new StreamReader(ConsoleArguments.InputFile, Encoding.UTF8))
            {
                content = streamReader.ReadToEnd();
            }
            return content;
        }

        /// <inheritdoc/>
        public void WriteIntoFile(string outputResult)
        {
            var outputFile = File.Create(ConsoleArguments.OutputFile);

            using (StreamWriter sw = new StreamWriter(outputFile))
            {
                sw.WriteLine(outputResult);
            }

            ConsoleLog.LogConvertedFile(outputFile.Name);
        }
    }
}
