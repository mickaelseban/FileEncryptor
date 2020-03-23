namespace FileEncryptor.Application.Services
{
    using FileEncryptor.Application.Model.User.Enums;

    public interface IUserAccessService
    {
        bool CanAccess(UserRoleType? userUserRole, UserOperationType? userOperation, UserAccessOperationType? userAccessOperationType);
    }
}
