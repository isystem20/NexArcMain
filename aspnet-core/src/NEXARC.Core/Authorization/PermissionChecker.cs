using Abp.Authorization;
using NEXARC.Authorization.Roles;
using NEXARC.Authorization.Users;

namespace NEXARC.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
