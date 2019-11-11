using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Dashboard_OxygenWeb.MultiTenancy;

namespace Dashboard_OxygenWeb.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
