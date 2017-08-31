using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using RjcErp.Configuration.Dto;

namespace RjcErp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : RjcErpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
