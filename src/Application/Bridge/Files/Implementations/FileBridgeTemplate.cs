namespace FileEncryptor.Application.Bridge.Files.Implementations
{
    using FileEncryptor.Application.Bridge.Encryption;
    using FileEncryptor.Application.Bridge.Readers;

    public abstract class FileBridgeTemplate
    {
        protected IEncryption Encryption;
        protected IFileReader FileReader;

        protected FileBridgeTemplate(IEncryption encryption, IFileReader fileReader)
        {
            this.Encryption = encryption;
            this.FileReader = fileReader;
        }

        public abstract string Print();
    }
}
