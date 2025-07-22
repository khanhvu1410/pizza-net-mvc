using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PizzaNet.Domain.Entities;
using PizzaNet.Persistence.DataSeeders;

namespace PizzaNet.Persistence
{
    public class PizzaNetDbContext : DbContext
    {
        public PizzaNetDbContext(DbContextOptions<PizzaNetDbContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetPrecision(18);
                property.SetScale(6);
            }

            CategorySeeder.Seed(modelBuilder);  
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Crust> Crusts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get;set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
