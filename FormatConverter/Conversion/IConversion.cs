namespace FormatConverter.Conversion
{
    /// <summary>
    /// Interface for different formats 
    /// </summary>
    public interface IConversion
    {
        /// <summary>
        /// Converts to the given format
        /// </summary>
        /// <param name="fileToConvert"> File to convert </param>
        /// <returns> Converted file </returns>
        string ConvertToFormat(string fileToConvert);
    }
}
