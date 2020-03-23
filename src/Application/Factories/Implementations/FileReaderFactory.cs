namespace FileEncryptor.Application.Factories.Implementations
{
    using FileEncryptor.Application.Bridge.Readers;
    using FileEncryptor.Application.Bridge.Readers.Implementations;
    using FileEncryptor.Application.Dto.Enums;
    using System;

    internal class FileReaderFactory : IFileReaderFactory
    {
        public IFileReader Create(FileReaderTypeDto fileReaderTypeDto, string fileName)
        {
            switch (fileReaderTypeDto)
            {
                case FileReaderTypeDto.TextFile: return new TextFileReader(fileName);

                case FileReaderTypeDto.XmlFile: return new XmlFileReader(fileName);

                case FileReaderTypeDto.JsonFile: return new JsonFileReader(fileName);

                default: throw new ArgumentOutOfRangeException(nameof(fileReaderTypeDto), fileReaderTypeDto, null);
            }
        }
    }
}
