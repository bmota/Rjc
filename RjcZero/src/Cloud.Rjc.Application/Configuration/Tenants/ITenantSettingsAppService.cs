using System.Threading.Tasks;
using Abp.Application.Services;
using Cloud.Rjc.Configuration.Tenants.Dto;

namespace Cloud.Rjc.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
