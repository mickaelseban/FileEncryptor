namespace FileEncryptor.Application.Bridge.Files.Implementations
{
    using FileEncryptor.Application.Bridge.Encryption;
    using FileEncryptor.Application.Bridge.Readers;

    public class FileBridge : FileBridgeTemplate, IFile
    {
        public FileBridge(IEncryption encryption, IFileReader fileReader)
            : base(encryption, fileReader)
        {
        }

        public override string Print()
        {
            return this.Encryption.Execute(this.FileReader.Read());
        }
    }
}
