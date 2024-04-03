using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistence
{
     public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeatureGroup> Product { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.ApplyConfiguration(new ProductConfig());
            // modelBuilder.ApplyConfiguration(new CategoryConfig());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}