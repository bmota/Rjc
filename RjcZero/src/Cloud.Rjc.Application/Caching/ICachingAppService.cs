using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Cloud.Rjc.Caching.Dto;

namespace Cloud.Rjc.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
