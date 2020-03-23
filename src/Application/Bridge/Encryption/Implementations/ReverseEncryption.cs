namespace FileEncryptor.Application.Bridge.Encryption.Implementations
{
    using System.Linq;

    public class ReverseEncryption : IEncryption
    {
        public string Execute(string value)
        {
            return new string(value.Reverse().ToArray());
        }
    }
}
