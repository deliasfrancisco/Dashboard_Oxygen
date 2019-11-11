using Abp.Authorization;
using Dashboard_OxygenWeb.Authorization.Roles;
using Dashboard_OxygenWeb.Authorization.Users;

namespace Dashboard_OxygenWeb.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
