using Abp.Authorization;
using Cloud.Rjc.Authorization.Roles;
using Cloud.Rjc.Authorization.Users;
using Cloud.Rjc.MultiTenancy;

namespace Cloud.Rjc.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
