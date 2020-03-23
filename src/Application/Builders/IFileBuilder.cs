namespace FileEncryptor.Application.Builders
{
    using FileEncryptor.Application.Bridge.Files;
    using FileEncryptor.Application.Dto;

    public interface IFileBuilder
    {
        IFileBuilder Build();

        IFileBuilder CreateFileBuilder(NewFileDto newFile);

        IFile Get();
    }
}
