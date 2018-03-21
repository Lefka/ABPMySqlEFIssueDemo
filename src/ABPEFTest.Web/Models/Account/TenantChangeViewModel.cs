using Abp.AutoMapper;
using ABPEFTest.Sessions.Dto;

namespace ABPEFTest.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}