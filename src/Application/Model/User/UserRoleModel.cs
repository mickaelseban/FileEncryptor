namespace FileEncryptor.Application.Model.User
{
    using FileEncryptor.Application.Model.User.Enums;

    public class UserRoleModel
    {
        public UserRoleModel(UserRoleType name, params UserOperationModel[] userOperations)
        {
            this.Name = name;
            this.UserOperations = userOperations;
        }

        public UserRoleType Name { get; }

        public UserOperationModel[] UserOperations { get; }
    }
}
