using Abp.Authorization;
using ABPEFTest.Authorization.Roles;
using ABPEFTest.Authorization.Users;

namespace ABPEFTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
