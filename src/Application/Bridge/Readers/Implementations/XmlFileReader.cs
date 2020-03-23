namespace FileEncryptor.Application.Bridge.Readers.Implementations
{
    using System.IO;
    using System.Text;
    using System.Xml;

    public class XmlFileReader : IFileReader
    {
        private readonly string _fileName;

        public XmlFileReader(string fileName)
        {
            this._fileName = fileName;
        }

        public string Read()
        {
            using (var fileStream = new FileStream(this._fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var mStream = new MemoryStream();
                var writer = new XmlTextWriter(mStream, Encoding.Unicode);
                var document = new XmlDocument();

                document.Load(fileStream);

                writer.Formatting = Formatting.Indented;

                document.WriteContentTo(writer);
                writer.Flush();
                mStream.Flush();

                mStream.Position = 0;

                var sReader = new StreamReader(mStream);

                var formattedXml = sReader.ReadToEnd();
                return formattedXml;
            }
        }
    }
}
