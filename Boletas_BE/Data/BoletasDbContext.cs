using Boletas_BE.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Boletas_BE.Data
{
    public class BoletasDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public BoletasDbContext(DbContextOptions<BoletasDbContext> options)
        : base(options) { }

        public DbSet<Usuarios> Usuario => Set<Usuarios>();
        public DbSet<Marca> Marcas => Set<Marca>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>(e => e.HasKey(k => k.Id));
            modelBuilder.Entity<Marca>(e => e.HasKey(k => k.Id));
            base.OnModelCreating(modelBuilder);
        }
    }
}
