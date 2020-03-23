namespace FileEncryptor.Application.Factories
{
    using FileEncryptor.Application.Bridge.Encryption;
    using FileEncryptor.Application.Dto.Enums;

    public interface IEncryptionFactory
    {
        IEncryption Create(EncryptionTypeDto encryptionType);
    }
}
