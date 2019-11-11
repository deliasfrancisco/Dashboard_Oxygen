using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Dashboard_OxygenWeb.EntityFrameworkCore
{
    public static class Dashboard_OxygenWebDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Dashboard_OxygenWebDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Dashboard_OxygenWebDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
