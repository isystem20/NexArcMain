using System.Threading.Tasks;
using NEXARC.Configuration.Dto;

namespace NEXARC.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
