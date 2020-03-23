namespace FileEncryptor.Application.Bridge.Readers.Implementations
{
    using System.IO;

    public class TextFileReader : IFileReader
    {
        private readonly string _fileName;

        public TextFileReader(string fileName)
        {
            this._fileName = fileName;
        }

        public string Read()
        {
            using (var fileStream = new FileStream(this._fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }
    }
}
