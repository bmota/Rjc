using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RjcErp.MultiTenancy.Dto;

namespace RjcErp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
