namespace FileEncryptor.Presentation.Console.Adapters
{
    using FileEncryptor.Application.Dto;
    using FileEncryptor.Presentation.Console.ViewModel;

    internal interface IUserConsoleInputViewModelToNewFileDtoAdapter
    {
        NewFileDto Adapt(UserConsoleInputViewModel userConsoleInputViewModel);
    }
}
