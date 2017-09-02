using Abp.Application.Services;
using Cloud.Rjc.Tenants.Dashboard.Dto;

namespace Cloud.Rjc.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
