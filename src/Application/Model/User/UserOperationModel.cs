namespace FileEncryptor.Application.Model.User
{
    using FileEncryptor.Application.Model.User.Enums;

    public class UserOperationModel
    {
        public UserOperationModel(UserOperationType userOperationType, UserAccessOperationType userAccessOperationType)
        {
            this.UserOperationType = userOperationType;
            this.UserAccessOperationType = userAccessOperationType;
        }

        public UserAccessOperationType UserAccessOperationType { get; }
        public UserOperationType UserOperationType { get; }
    }
}
