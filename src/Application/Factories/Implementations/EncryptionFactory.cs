namespace FileEncryptor.Application.Factories.Implementations
{
    using FileEncryptor.Application.Bridge.Encryption;
    using FileEncryptor.Application.Bridge.Encryption.Implementations;
    using FileEncryptor.Application.Dto.Enums;
    using System;

    internal class EncryptionFactory : IEncryptionFactory
    {
        public IEncryption Create(EncryptionTypeDto encryptionType)
        {
            switch (encryptionType)
            {
                case EncryptionTypeDto.NoEncryption: return new NoEncryption();

                case EncryptionTypeDto.ReverseEncryption: return new ReverseEncryption();

                default: throw new ArgumentOutOfRangeException(nameof(encryptionType), encryptionType, null);
            }
        }
    }
}
