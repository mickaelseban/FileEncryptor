namespace FileEncryptor.Application.Services
{
    using FileEncryptor.Application.Dto;

    public interface IFilesService
    {
        string ReadNewFile(NewFileDto newFile);
    }
}
