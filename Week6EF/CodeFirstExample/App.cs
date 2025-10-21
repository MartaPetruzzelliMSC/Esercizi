using CodeFirstExample.Data;
using CodeFirstExample.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CodeFirstExample;

public class App
{
    private readonly CodeFirstDbContext _context;

    public App(CodeFirstDbContext codeFirstDbContext)
    {
        _context = codeFirstDbContext;
    }

    public void Run()
    {
        bool exit = false;



        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=== Console Menu ===");
            Console.WriteLine("1   - Create Database");
            Console.WriteLine("2   - Create new Warehouse and new Products");
            Console.WriteLine("3   - Read and display data from the database");
            Console.WriteLine("ESC - Exit");
            Console.Write("Choose an option: ");

            var key = Console.ReadKey(intercept: true).Key;

            Console.WriteLine(); // Move to next line

            switch (key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    _context.Database.EnsureCreated();

                    Console.WriteLine("Database created successfully!");
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    // Check if database exists
                    if (!_context.Database.CanConnect())
                    {
                        Console.WriteLine("Database does not exist. Please create the database first.");
                        break;
                    }

                    // Create a new Warehouse and a new Product
                    var warehouse = new Warehouse { Location = "Torino" };
                    _context.Warehouses.Add(warehouse);
                    _context.SaveChanges();

                    var product = new Product
                    {
                        Name = "Pizza Margherita",
                        Price = 8.50m,
                        WarehouseId = warehouse.Id
                    };
                    _context.Products.Add(product);

                    var product1 = new Product
                    {
                        Name = "Olio di Oliva",
                        Price = 19.90m,
                        WarehouseId = warehouse.Id
                    };
                    _context.Products.Add(product1);
                    _context.SaveChanges();

                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    // Read and display data from the database
                    if (!_context.Database.CanConnect())
                    {
                        Console.WriteLine("Database does not exist. Please create the database first.");
                        break;
                    }
                    var warehouses = _context.Warehouses.Include(w => w.Products).ToList();
                    foreach (var wh in warehouses)
                    {
                        Console.WriteLine($"Warehouse ID: {wh.Id}, Location: {wh.Location}");
                        foreach (var prod in wh.Products)
                        {
                            Console.WriteLine($"\tProduct ID: {prod.Id}, Name: {prod.Name}, Price: {prod.Price:C}");
                        }
                    }
                    break;

                case ConsoleKey.Escape:
                    Console.WriteLine("Exiting...");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey(intercept: true);
            }
        }
    }
}


