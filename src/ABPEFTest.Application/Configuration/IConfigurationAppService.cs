using System.Threading.Tasks;
using Abp.Application.Services;
using ABPEFTest.Configuration.Dto;

namespace ABPEFTest.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}