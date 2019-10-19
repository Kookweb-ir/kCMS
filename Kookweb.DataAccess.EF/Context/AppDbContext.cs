using Microsoft.EntityFrameworkCore;
using Kookweb.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Kookweb.DataAccess.EF.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> City { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);            
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entityType.Name).ToTable(entityType.ClrType.Name);
            }
        }
    }
}
