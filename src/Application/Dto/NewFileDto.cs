namespace FileEncryptor.Application.Dto
{
    using FileEncryptor.Application.Dto.Enums;

    public class NewFileDto
    {
        public EncryptionTypeDto EncryptionType { get; set; }

        public string FileName { get; set; }

        public FileReaderTypeDto FileReaderType { get; set; }
    }
}
