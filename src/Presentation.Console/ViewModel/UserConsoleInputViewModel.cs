namespace FileEncryptor.Presentation.Console.ViewModel
{
    using FileEncryptor.Application.Model.User.Enums;

    internal class UserConsoleInputViewModel
    {
        public UserAccessOperationType AccessOperation { get; set; }
        public string FileName { get; set; }
        public UserOperationType Operation { get; set; }

        public UserRoleType UserRole { get; set; }
    }
}
