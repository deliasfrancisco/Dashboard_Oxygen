using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Dashboard_OxygenWeb.Authorization.Roles;
using Dashboard_OxygenWeb.Authorization.Users;
using Dashboard_OxygenWeb.MultiTenancy;

namespace Dashboard_OxygenWeb.EntityFrameworkCore
{
    public class Dashboard_OxygenWebDbContext : AbpZeroDbContext<Tenant, Role, User, Dashboard_OxygenWebDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Dashboard_OxygenWebDbContext(DbContextOptions<Dashboard_OxygenWebDbContext> options)
            : base(options)
        {
        }
    }
}
