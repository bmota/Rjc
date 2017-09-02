using System.Threading.Tasks;
using Abp.Application.Services;
using Cloud.Rjc.Sessions.Dto;

namespace Cloud.Rjc.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
