using System.Threading.Tasks;
using Abp.Application.Services;
using RjcErp.Authorization.Accounts.Dto;

namespace RjcErp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
