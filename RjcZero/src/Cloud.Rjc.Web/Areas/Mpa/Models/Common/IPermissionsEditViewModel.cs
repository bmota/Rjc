using System.Collections.Generic;
using Cloud.Rjc.Authorization.Permissions.Dto;

namespace Cloud.Rjc.Web.Areas.Mpa.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}