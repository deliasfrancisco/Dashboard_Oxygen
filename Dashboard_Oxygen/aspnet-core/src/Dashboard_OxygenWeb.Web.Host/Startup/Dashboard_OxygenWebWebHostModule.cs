using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dashboard_OxygenWeb.Configuration;

namespace Dashboard_OxygenWeb.Web.Host.Startup
{
    [DependsOn(
       typeof(Dashboard_OxygenWebWebCoreModule))]
    public class Dashboard_OxygenWebWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Dashboard_OxygenWebWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Dashboard_OxygenWebWebHostModule).GetAssembly());
        }
    }
}
