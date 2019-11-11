using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Dashboard_OxygenWeb.MultiTenancy.Dto;

namespace Dashboard_OxygenWeb.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

