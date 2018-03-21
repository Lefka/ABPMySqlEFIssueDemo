using System.Threading.Tasks;
using Abp.Application.Services;
using ABPEFTest.Sessions.Dto;

namespace ABPEFTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
