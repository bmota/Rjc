﻿using System.Collections.Generic;
using RjcErp.Roles.Dto;

namespace RjcErp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}