using System.Threading.Tasks;
using Abp.Application.Services;
using RjcErp.Configuration.Dto;

namespace RjcErp.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}