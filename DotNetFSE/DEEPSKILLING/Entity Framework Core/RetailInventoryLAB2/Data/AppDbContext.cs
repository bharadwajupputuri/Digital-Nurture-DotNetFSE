using Microsoft.EntityFrameworkCore;
using RetailInventoryLAB2.Models;

namespace RetailInventoryLAB2.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=RetailInventoryLab2Db;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}