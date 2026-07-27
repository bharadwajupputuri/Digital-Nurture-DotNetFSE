using Microsoft.EntityFrameworkCore;
using RetailInventoryLAB7.Models;

namespace RetailInventoryLAB7.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\MSSQLLocalDB;Database=RetailInventoryLab7Db;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}