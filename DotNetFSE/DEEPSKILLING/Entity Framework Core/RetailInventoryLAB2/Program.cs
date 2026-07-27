using RetailInventoryLAB2.Data;
using RetailInventoryLAB2.Models;

using var context = new AppDbContext();

// Create the database
context.Database.EnsureCreated();

// Add Category
var category = new Category
{
    Name = "Electronics"
};

context.Categories.Add(category);
context.SaveChanges();

// Add Product
var product = new Product
{
    Name = "Laptop",
    Price = 55000,
    CategoryId = category.Id
};

context.Products.Add(product);
context.SaveChanges();

Console.WriteLine("Category inserted successfully.");
Console.WriteLine("Product inserted successfully.");
Console.WriteLine("Database created successfully.");