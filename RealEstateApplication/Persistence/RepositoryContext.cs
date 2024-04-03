using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistence
{
     public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeatureGroup> ProductFeature { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}