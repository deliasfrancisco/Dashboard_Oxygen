using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dashboard_OxygenWeb.Configuration;
using Dashboard_OxygenWeb.EntityFrameworkCore;
using Dashboard_OxygenWeb.Migrator.DependencyInjection;

namespace Dashboard_OxygenWeb.Migrator
{
    [DependsOn(typeof(Dashboard_OxygenWebEntityFrameworkModule))]
    public class Dashboard_OxygenWebMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Dashboard_OxygenWebMigratorModule(Dashboard_OxygenWebEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(Dashboard_OxygenWebMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                Dashboard_OxygenWebConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Dashboard_OxygenWebMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
