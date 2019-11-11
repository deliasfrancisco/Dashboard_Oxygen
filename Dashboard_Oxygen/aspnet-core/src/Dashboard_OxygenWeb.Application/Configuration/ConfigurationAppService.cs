using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Dashboard_OxygenWeb.Configuration.Dto;

namespace Dashboard_OxygenWeb.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Dashboard_OxygenWebAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
