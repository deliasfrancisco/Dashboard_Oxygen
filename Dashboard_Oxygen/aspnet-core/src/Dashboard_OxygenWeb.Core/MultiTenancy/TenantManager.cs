using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Dashboard_OxygenWeb.Authorization.Users;
using Dashboard_OxygenWeb.Editions;

namespace Dashboard_OxygenWeb.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
