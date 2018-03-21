using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPEFTest.Configuration.Dto;

namespace ABPEFTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPEFTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
