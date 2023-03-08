using Newtonsoft.Json;

namespace FormatConverter.Conversion
{
    /// <summary>
    /// Convert from any given file to XML
    /// </summary>
    public class ConvertToXML : IConversion
    {
        /// <inheritdoc/>
        public string ConvertToFormat(string fileToConvert)
        {
            if (ConsoleArguments.InputFormat.Equals(ValidArgValues.JSON))
                return ConvertFromJson(fileToConvert);

            else
                return "";
        }

        /// <summary>
        /// Convert from JSON to XML
        /// </summary>
        /// <param name="fileToConvert"> File to Convert </param>
        /// <returns> Converted file </returns>
        private string ConvertFromJson(string fileToConvert) 
        {
            ConsoleLog.LogConvertingFormat(ValidArgValues.JSON, ValidArgValues.XML);
            return JsonConvert.DeserializeXNode(fileToConvert).ToString();
        }
    }
}
