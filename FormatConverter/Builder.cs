using FormatConverter.Conversion;
using FormatConverter.Storages;

namespace FormatConverter
{
    /// <summary>
    /// Class used for initializing types of storages and formats based on user params
    /// </summary>
    public class Builder
    {
        /// <summary>
        /// Type of input storage based on user params
        /// </summary>
        public IStorage InputStorage;

        /// <summary>
        /// Type of output storage based on user params
        /// </summary>
        public IStorage OutputStorage;

        /// <summary>
        /// Type of target format based on user params
        /// </summary>
        public IConversion OutputFormat;

        public Builder(string inputStorage, string outputFormat, string outputStorage)
        {
            // input storage
            if (inputStorage.Equals("FileSystem"))
                InputStorage = new FileSystem();

            // convert to
            if (outputFormat.Equals("JSON"))
                OutputFormat = new ConvertToJSON();
            else if (outputFormat.Equals("XML"))
                OutputFormat = new ConvertToXML();

            // output storage
            if (outputStorage.Equals("FileSystem"))
                OutputStorage = new FileSystem();
            
        }
    }
}
