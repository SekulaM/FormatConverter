namespace FormatConverter.Storages
{
    /// <summary>
    /// Interface for different types of file storages
    /// </summary>
    public interface IStorage
    {
        /// <summary>
        /// Reads all text from a file
        /// </summary>
        /// <returns> Content of the file </returns>
        string ReadFromFile();

        /// <summary>
        /// Writes the converted format into the output file
        /// </summary>
        /// <param name="outputResult"> Content to be written into the output file </param>
        void WriteIntoFile(string outputResult);
    }
}
