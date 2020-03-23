namespace FileEncryptor.Application.Services.Implementations
{
    using FileEncryptor.Application.Builders;
    using FileEncryptor.Application.Dto;

    public class FilesService : IFilesService
    {
        private readonly IFileBuilder _fileBuilder;

        public FilesService(IFileBuilder fileBuilder)
        {
            this._fileBuilder = fileBuilder;
        }

        public string ReadNewFile(NewFileDto newFile)
        {
            var file = this._fileBuilder.CreateFileBuilder(newFile)
                .Build()
                .Get();

            return file.Print();
        }
    }
}
