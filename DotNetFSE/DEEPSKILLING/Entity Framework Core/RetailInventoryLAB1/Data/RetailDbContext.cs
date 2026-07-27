using Microsoft.EntityFrameworkCore;
using RetailInventoryLAB1.Models;

namespace RetailInventoryLAB1.Data
{
    public class RetailDbContext : DbContext
    {
        public RetailDbContext(DbContextOptions<RetailDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}