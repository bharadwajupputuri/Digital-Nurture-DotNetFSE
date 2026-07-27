using Microsoft.EntityFrameworkCore;
using RetailInventoryLAB7.Data;
using RetailInventoryLAB7.Models;

using var context = new AppDbContext();

// Insert sample data if database is empty
if (!await context.Categories.AnyAsync())
{
    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };

    await context.Categories.AddRangeAsync(electronics, groceries);

    await context.Products.AddRangeAsync(
        new Product
        {
            Name = "Laptop",
            Price = 70000,
            Category = electronics
        },
        new Product
        {
            Name = "Rice Bag",
            Price = 1200,
            Category = groceries
        },
        new Product
        {
            Name = "Mouse",
            Price = 800,
            Category = electronics
        },
        new Product
        {
            Name = "Keyboard",
            Price = 1800,
            Category = electronics
        });

    await context.SaveChangesAsync();

    Console.WriteLine("Sample data inserted.\n");
}

// Filter and Sort
var filtered = await context.Products
    .Where(p => p.Price > 1000)
    .OrderByDescending(p => p.Price)
    .ToListAsync();

Console.WriteLine("Products with Price > 1000 (Sorted Descending):");

foreach (var product in filtered)
{
    Console.WriteLine($"{product.Name} - ₹{product.Price}");
}

// Project into DTO (Anonymous Object)

Console.WriteLine("\nProduct DTOs:");

var productDTOs = await context.Products
    .Select(p => new
    {
        p.Name,
        p.Price
    })
    .ToListAsync();

foreach (var item in productDTOs)
{
    Console.WriteLine($"{item.Name} - ₹{item.Price}");
}