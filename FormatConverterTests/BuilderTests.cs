using FormatConverter;
using FormatConverter.Conversion;
using FormatConverter.Storages;

namespace FormatConverterTests
{
    [TestClass]
    public class BuilderTests
    {
        /// <summary>
        /// Tests that proper types have been created
        /// </summary>
        /// <param name="inputStorageType"></param>
        /// <param name="outputFormat"></param>
        /// <param name="outputStorageType"></param>
        [TestMethod]
        [DataRow("FileSystem", "JSON", "FileSystem")]
        public void CreateBuilderInstance_ReturnProperTypes(string inputStorageType, string outputFormat, string outputStorageType)
        {
            Builder builder = new Builder(inputStorageType, outputFormat, outputStorageType);

            Assert.IsTrue(builder.InputStorage.GetType() == typeof(FileSystem));
            Assert.IsTrue(builder.OutputFormat.GetType() == typeof(ConvertToJSON));
            Assert.IsTrue(builder.InputStorage.GetType() == typeof(FileSystem));
        }
    }
}
