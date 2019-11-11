using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using Dashboard_OxygenWeb.Authorization.Roles;
using Dashboard_OxygenWeb.Authorization.Users;
using Dashboard_OxygenWeb.Configuration;
using Dashboard_OxygenWeb.Localization;
using Dashboard_OxygenWeb.MultiTenancy;
using Dashboard_OxygenWeb.Timing;

namespace Dashboard_OxygenWeb
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class Dashboard_OxygenWebCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            Dashboard_OxygenWebLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = Dashboard_OxygenWebConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Dashboard_OxygenWebCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
