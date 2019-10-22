using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using NEXARC.Configuration.Dto;

namespace NEXARC.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NEXARCAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
