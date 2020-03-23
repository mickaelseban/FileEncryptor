namespace FileEncryptor.Presentation.Console.Adapters.Implementations
{
    using FileEncryptor.Application.Dto.Enums;
    using FileEncryptor.Application.Model.User.Enums;
    using System;

    internal class UserAccessOperationTypeToEncryptionTypeDtoAdapter : IUserAccessOperationTypeToEncryptionTypeDtoAdapter
    {
        public EncryptionTypeDto Adapt(UserAccessOperationType accessOperation)
        {
            switch (accessOperation)
            {
                case UserAccessOperationType.Print:
                    return EncryptionTypeDto.NoEncryption;

                case UserAccessOperationType.PrintEncrypted:
                    return EncryptionTypeDto.ReverseEncryption;

                case UserAccessOperationType.NoPermission:
                    throw new InvalidOperationException("User has no permission");

                default: throw new ArgumentOutOfRangeException(nameof(accessOperation), accessOperation, null);
            }
        }
    }
}
