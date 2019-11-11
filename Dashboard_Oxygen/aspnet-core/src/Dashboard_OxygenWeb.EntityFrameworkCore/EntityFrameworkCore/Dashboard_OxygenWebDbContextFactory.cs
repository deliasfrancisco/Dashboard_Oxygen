using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Dashboard_OxygenWeb.Configuration;
using Dashboard_OxygenWeb.Web;

namespace Dashboard_OxygenWeb.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Dashboard_OxygenWebDbContextFactory : IDesignTimeDbContextFactory<Dashboard_OxygenWebDbContext>
    {
        public Dashboard_OxygenWebDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Dashboard_OxygenWebDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Dashboard_OxygenWebDbContextConfigurer.Configure(builder, configuration.GetConnectionString(Dashboard_OxygenWebConsts.ConnectionStringName));

            return new Dashboard_OxygenWebDbContext(builder.Options);
        }
    }
}
