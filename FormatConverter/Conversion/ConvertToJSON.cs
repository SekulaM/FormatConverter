using Newtonsoft.Json;
using System.Xml.Linq;

namespace FormatConverter.Conversion
{
    /// <summary>
    /// Convert from any given file to JSON
    /// </summary>
    public class ConvertToJSON : IConversion
    {
        /// <inheritdoc/>
        public string ConvertToFormat(string fileToConvert)
        {
            if (ConsoleArguments.InputFormat.Equals(ValidArgValues.XML))
                return ConvertFromXML(fileToConvert);

            else
                return "";
        }

        /// <summary>
        /// Convert from XML to JSON
        /// </summary>
        /// <param name="fileToConvert"></param>
        /// <returns> Converted file </returns>
        private string ConvertFromXML(string fileToConvert)
        {
            ConsoleLog.LogConvertingFormat(ValidArgValues.XML, ValidArgValues.JSON);
            var xdoc = XDocument.Parse(fileToConvert);

            return JsonConvert.SerializeXNode(xdoc, Formatting.Indented);
        }
    }
}
