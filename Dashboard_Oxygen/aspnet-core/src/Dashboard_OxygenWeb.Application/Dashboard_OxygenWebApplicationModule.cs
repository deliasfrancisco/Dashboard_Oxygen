using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dashboard_OxygenWeb.Authorization;

namespace Dashboard_OxygenWeb
{
    [DependsOn(
        typeof(Dashboard_OxygenWebCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Dashboard_OxygenWebApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Dashboard_OxygenWebAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Dashboard_OxygenWebApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
