using Abp.Authorization;
using RjcErp.Authorization.Roles;
using RjcErp.Authorization.Users;

namespace RjcErp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
