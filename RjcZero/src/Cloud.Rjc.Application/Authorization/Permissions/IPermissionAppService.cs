using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Cloud.Rjc.Authorization.Permissions.Dto;

namespace Cloud.Rjc.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
