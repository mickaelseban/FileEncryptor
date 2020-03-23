namespace FileEncryptor.Application.Factories
{
    using FileEncryptor.Application.Bridge.Readers;
    using FileEncryptor.Application.Dto.Enums;

    public interface IFileReaderFactory
    {
        IFileReader Create(FileReaderTypeDto fileReaderTypeDto, string fileName);
    }
}
