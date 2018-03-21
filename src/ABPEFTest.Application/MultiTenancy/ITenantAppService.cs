using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPEFTest.MultiTenancy.Dto;

namespace ABPEFTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
