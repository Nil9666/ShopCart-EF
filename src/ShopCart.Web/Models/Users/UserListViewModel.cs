using System.Collections.Generic;
using ShopCart.Roles.Dto;
using ShopCart.Users.Dto;

namespace ShopCart.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}