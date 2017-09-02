using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Cloud.Rjc.Common.Dto;

namespace Cloud.Rjc.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<ComboboxItemDto>> GetEditionsForCombobox();

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        string GetDefaultEditionName();
    }
}