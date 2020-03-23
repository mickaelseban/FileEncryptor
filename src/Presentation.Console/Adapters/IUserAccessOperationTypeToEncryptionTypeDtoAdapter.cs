namespace FileEncryptor.Presentation.Console.Adapters
{
    using FileEncryptor.Application.Dto.Enums;
    using FileEncryptor.Application.Model.User.Enums;

    internal interface IUserAccessOperationTypeToEncryptionTypeDtoAdapter
    {
        EncryptionTypeDto Adapt(UserAccessOperationType accessOperation);
    }
}
