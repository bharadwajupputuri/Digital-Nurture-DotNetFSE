using Microsoft.EntityFrameworkCore;
using RetailInventoryLAB1.Data;
using RetailInventoryLAB1.Models;

var builder = new DbContextOptionsBuilder<RetailDbContext>();

builder.UseSqlServer(
    "Server=(localdb)\\MSSQLLocalDB;Database=RetailInventoryDB;Trusted_Connection=True;TrustServerCertificate=True;"
);

using var context = new RetailDbContext(builder.Options);

// Add a Category
var category = new Category
{
    CategoryName = "Electronics"
};

context.Categories.Add(category);
context.SaveChanges();

// Add a Product
var product = new Product
{
    ProductName = "Laptop",
    Price = 55000,
    Stock = 10,
    CategoryId = category.CategoryId
};

context.Products.Add(product);
context.SaveChanges();

Console.WriteLine("Data inserted successfully!");