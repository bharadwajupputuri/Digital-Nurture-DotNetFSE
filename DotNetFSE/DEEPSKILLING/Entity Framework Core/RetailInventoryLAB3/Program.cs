using System;
using RetailInventoryLAB3.Data;

namespace RetailInventoryLAB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("EF Core Migration Lab Ready.");
        }
    }
}