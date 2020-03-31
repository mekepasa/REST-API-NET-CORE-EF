using System;
using Microsoft.EntityFrameworkCore;

namespace ServicioRESTASP.NETCoreEF.Models
{
    public class CaducaContext : DbContext
    {
        public CaducaContext(DbContextOptions<CaducaContext> options) : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
    }
}
