using Microsoft.EntityFrameworkCore;
using RetailInventoryLAB5.Data;
using RetailInventoryLAB5.Models;

using var context = new AppDbContext();

// Insert sample data only if the database is empty
if (!await context.Categories.AnyAsync())
{
    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };

    await context.Categories.AddRangeAsync(electronics, groceries);

    await context.Products.AddRangeAsync(
        new Product
        {
            Name = "Laptop",
            Price = 75000,
            Category = electronics
        },
        new Product
        {
            Name = "Rice Bag",
            Price = 1200,
            Category = groceries
        });

    await context.SaveChangesAsync();
}

// Retrieve all products
Console.WriteLine("All Products:");
var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

// Find by ID
var product = await context.Products.FindAsync(1);
Console.WriteLine($"\nFound: {product?.Name}");

// First product with price greater than 50000
var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

Console.WriteLine($"Expensive: {expensive?.Name}");