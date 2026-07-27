using Microsoft.EntityFrameworkCore;
using RetailInventoryLAB3.Models;

namespace RetailInventoryLAB3.Data
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
                    "Server=(localdb)\\MSSQLLocalDB;Database=RetailInventoryLab3Db;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}