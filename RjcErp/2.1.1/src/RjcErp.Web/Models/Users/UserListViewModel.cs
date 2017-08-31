using System.Collections.Generic;
using RjcErp.Roles.Dto;
using RjcErp.Users.Dto;

namespace RjcErp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}