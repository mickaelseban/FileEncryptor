namespace FileEncryptor.Application.Services.Implementations
{
    using FileEncryptor.Application.Model.User;
    using FileEncryptor.Application.Model.User.Enums;
    using System.Collections.Generic;
    using System.Linq;

    public class UserAccessService : IUserAccessService
    {
        public bool CanAccess(UserRoleType? userUserRole, UserOperationType? userOperation, UserAccessOperationType? userAccessOperationType)
        {
            UserAccessOperationType? userAccessOperationResult = GetUserAccessModel().UserRoles
                ?.FirstOrDefault(m => m.Name == userUserRole)
                ?.UserOperations.FirstOrDefault(m => m.UserOperationType == userOperation)
                ?.UserAccessOperationType;

            if (!userAccessOperationResult.HasValue)
            {
                return false;
            }

            return userAccessOperationType == userAccessOperationResult.Value;
        }

        private static UserAccessModel GetUserAccessModel()
        {
            return new UserAccessModel
            {
                UserRoles = new List<UserRoleModel>
                {
                    new UserRoleModel(UserRoleType.GuestUser,
                        new UserOperationModel(UserOperationType.ReadText, UserAccessOperationType.Print),
                        new UserOperationModel(UserOperationType.ReadXml, UserAccessOperationType.NoPermission),
                        new UserOperationModel(UserOperationType.ReadJson, UserAccessOperationType.NoPermission)
                    ),
                    new UserRoleModel(UserRoleType.RegularUser,
                        new UserOperationModel(UserOperationType.ReadText, UserAccessOperationType.PrintEncrypted),
                        new UserOperationModel(UserOperationType.ReadXml, UserAccessOperationType.Print),
                        new UserOperationModel(UserOperationType.ReadJson, UserAccessOperationType.Print)
                    ),
                    new UserRoleModel(UserRoleType.Admin,
                        new UserOperationModel(UserOperationType.ReadText, UserAccessOperationType.PrintEncrypted),
                        new UserOperationModel(UserOperationType.ReadXml, UserAccessOperationType.PrintEncrypted),
                        new UserOperationModel(UserOperationType.ReadJson, UserAccessOperationType.PrintEncrypted)
                    )
                }
            };
        }
    }
}
