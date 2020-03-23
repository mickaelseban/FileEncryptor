namespace FileEncryptor.Presentation.Console.Adapters.Implementations
{
    using FileEncryptor.Application.Dto;
    using FileEncryptor.Presentation.Console.ViewModel;

    internal class UserConsoleInputViewModelToNewFileDtoAdapter : IUserConsoleInputViewModelToNewFileDtoAdapter
    {
        private readonly IUserAccessOperationTypeToEncryptionTypeDtoAdapter encryptionTypeAdapter;
        private readonly IUserOperationTypeToFileReaderTypeDtoAdapter fileReaderTypeAdapter;

        public UserConsoleInputViewModelToNewFileDtoAdapter(IUserAccessOperationTypeToEncryptionTypeDtoAdapter encryptionTypeAdapter,
            IUserOperationTypeToFileReaderTypeDtoAdapter fileReaderTypeAdapter)
        {
            this.encryptionTypeAdapter = encryptionTypeAdapter;
            this.fileReaderTypeAdapter = fileReaderTypeAdapter;
        }

        public NewFileDto Adapt(UserConsoleInputViewModel userConsoleInputViewModel)
        {
            return new NewFileDto
            {
                FileReaderType = this.fileReaderTypeAdapter.Adapt(userConsoleInputViewModel.Operation),
                EncryptionType = this.encryptionTypeAdapter.Adapt(userConsoleInputViewModel.AccessOperation),
                FileName = userConsoleInputViewModel.FileName
            };
        }
    }
}
