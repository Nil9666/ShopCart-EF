using Abp.Authorization;
using ShopCart.Authorization.Roles;
using ShopCart.Authorization.Users;

namespace ShopCart.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
