# FormatConverter

Note on arguments:
There are six of them, all required. They should be written in the following format: 
/argument value

List of arguments: /InputFile  /OutputFile  /InputFormat  /OutputFormat  /StorageInput   /StorageOutput

Example XML to JSON: 
/InputFile TestFiles/testXMLFile.xml /OutputFile TestFiles\testOutput.json /InputFormat XML /OutputFormat JSON /StorageInput FileSystem /StorageOutput FileSystem

Example JSON to XML:
/InputFile TestFiles/testJSONFile.json /OutputFile TestFiles\testOutput.xml /InputFormat JSON /OutputFormat XML /StorageInput FileSystem /StorageOutput FileSystem
