using System.Threading.Tasks;
using Dashboard_OxygenWeb.Configuration.Dto;

namespace Dashboard_OxygenWeb.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
