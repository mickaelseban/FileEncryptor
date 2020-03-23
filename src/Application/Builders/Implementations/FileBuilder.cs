namespace FileEncryptor.Application.Builders.Implementations
{
    using FileEncryptor.Application.Bridge.Encryption;
    using FileEncryptor.Application.Bridge.Files;
    using FileEncryptor.Application.Bridge.Files.Implementations;
    using FileEncryptor.Application.Bridge.Readers;
    using FileEncryptor.Application.Dto;
    using FileEncryptor.Application.Dto.Enums;
    using FileEncryptor.Application.Factories;

    public class FileBuilder : IFileBuilder
    {
        private readonly IEncryptionFactory _encryptionFactory;
        private readonly IFileReaderFactory _fileReaderFactory;
        private IEncryption _encryption;
        private EncryptionTypeDto _encryptionType;
        private IFile _file;
        private string _fileName;
        private IFileReader _fileReader;
        private FileReaderTypeDto _fileReaderTypeDto;

        public FileBuilder(IEncryptionFactory encryptionFactory, IFileReaderFactory fileReaderFactory)
        {
            this._encryptionFactory = encryptionFactory;
            this._fileReaderFactory = fileReaderFactory;
        }

        public IFileBuilder Build()
        {
            this.CreateEncryption();
            this.CreateFileReader();
            this._file = new FileBridge(this._encryption, this._fileReader);
            return this;
        }

        public IFileBuilder CreateFileBuilder(NewFileDto newFile)
        {
            this._fileName = newFile.FileName;
            this._fileReaderTypeDto = newFile.FileReaderType;
            this._encryptionType = newFile.EncryptionType;
            return this;
        }

        public IFile Get()
        {
            return this._file;
        }

        private void CreateEncryption()
        {
            this._encryption = this._encryptionFactory.Create(this._encryptionType);
        }

        private void CreateFileReader()
        {
            this._fileReader = this._fileReaderFactory.Create(this._fileReaderTypeDto, this._fileName);
        }
    }
}
