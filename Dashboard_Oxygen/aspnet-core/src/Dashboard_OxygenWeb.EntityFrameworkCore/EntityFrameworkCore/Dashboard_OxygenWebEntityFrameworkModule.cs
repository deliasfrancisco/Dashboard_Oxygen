using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Dashboard_OxygenWeb.EntityFrameworkCore.Seed;

namespace Dashboard_OxygenWeb.EntityFrameworkCore
{
    [DependsOn(
        typeof(Dashboard_OxygenWebCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class Dashboard_OxygenWebEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<Dashboard_OxygenWebDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        Dashboard_OxygenWebDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        Dashboard_OxygenWebDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Dashboard_OxygenWebEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
