namespace FileEncryptor.Presentation.Console.Adapters.Implementations
{
    using FileEncryptor.Application.Dto.Enums;
    using FileEncryptor.Application.Model.User.Enums;
    using System;

    public class UserOperationTypeToFileReaderTypeDtoAdapter : IUserOperationTypeToFileReaderTypeDtoAdapter
    {
        public FileReaderTypeDto Adapt(UserOperationType operation)
        {
            switch (operation)
            {
                case UserOperationType.ReadText:
                    return FileReaderTypeDto.TextFile;

                case UserOperationType.ReadXml:
                    return FileReaderTypeDto.XmlFile;

                case UserOperationType.ReadJson:
                    return FileReaderTypeDto.JsonFile;

                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
            }
        }
    }
}
