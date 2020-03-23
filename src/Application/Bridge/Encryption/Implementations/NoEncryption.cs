namespace FileEncryptor.Application.Bridge.Encryption.Implementations
{
    public class NoEncryption : IEncryption
    {
        public string Execute(string value)
        {
            return value;
        }
    }
}
