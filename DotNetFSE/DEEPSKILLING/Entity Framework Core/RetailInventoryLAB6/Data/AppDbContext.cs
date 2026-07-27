using Microsoft.EntityFrameworkCore;
using RetailInventoryLAB6.Models;

namespace RetailInventoryLAB6.Data
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
                    "Server=(localdb)\\MSSQLLocalDB;Database=RetailInventoryLab6Db;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}