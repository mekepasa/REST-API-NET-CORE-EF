using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ServicioRESTASP.NETCoreEF.Models
{
    public class CaducaContext : DbContext
    {
        public CaducaContext(DbContextOptions<CaducaContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CaducaContext>
    {
        public CaducaContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<CaducaContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            return new CaducaContext(builder.Options);
        }
    }
}
