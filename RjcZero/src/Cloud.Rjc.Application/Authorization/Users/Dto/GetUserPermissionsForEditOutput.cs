using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Cloud.Rjc.Authorization.Permissions.Dto;

namespace Cloud.Rjc.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}