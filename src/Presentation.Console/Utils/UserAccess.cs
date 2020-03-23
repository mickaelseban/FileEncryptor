namespace FileEncryptor.Presentation.Console.Utils
{
    using FileEncryptor.Application.Model.User.Enums;
    using System;
    using System.Collections.Generic;

    public static class UserAccess
    {
        public static Dictionary<int, string> AvailableUserAccessOperations()
        {
            var availableUserAccessOperations = new Dictionary<int, string>();

            foreach (UserAccessOperationType uao in Enum.GetValues(typeof(UserAccessOperationType)))
            {
                if (uao != UserAccessOperationType.NoPermission)
                {
                    availableUserAccessOperations.Add((int)uao, uao.ToString());
                }
            }

            return availableUserAccessOperations;
        }

        public static Dictionary<int, string> AvailableUserOperations()
        {
            var availableUserOperations = new Dictionary<int, string>();

            foreach (UserOperationType uot in Enum.GetValues(typeof(UserOperationType)))
            {
                availableUserOperations.Add((int)uot, uot.ToString());
            }

            return availableUserOperations;
        }

        public static Dictionary<int, string> AvailableUserRoles()
        {
            var availableUserRoles = new Dictionary<int, string>();

            foreach (UserRoleType r in Enum.GetValues(typeof(UserRoleType)))
            {
                availableUserRoles.Add((int)r, r.ToString());
            }

            return availableUserRoles;
        }
    }
}
