using System.Threading.Tasks;
using Abp.Application.Services;
using RjcErp.Sessions.Dto;

namespace RjcErp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
