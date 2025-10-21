namespace CodeFirstExample.Data;

using CodeFirstExample.Models;
using Microsoft.EntityFrameworkCore;

public class CodeFirstDbContext : DbContext
{
    public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed dei country
        modelBuilder.Entity<Country>().HasData(
            new Country { Id = 1, Name = "Italia" },
            new Country { Id = 2, Name = "Francia" },
            new Country { Id = 3, Name = "Spagna" }
        );

        // Seed dei magazzini
        modelBuilder.Entity<Warehouse>().HasData(
            new Warehouse { Id = 1, Location = "Torino", CountryId = 1},
            new Warehouse { Id = 2, Location = "Genova", CountryId = 1 },
            new Warehouse { Id = 3, Location = "Lione", CountryId = 2 }
        );

        // Seed dei prodotti
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Monitor", Price = 199.99M, WarehouseId = 1 },
            new Product { Id = 2, Name = "Tastiera", Price = 49.99M, WarehouseId = 1 },
            new Product { Id = 3, Name = "Stampante", Price = 129.50M, WarehouseId = 2 },
            new Product { Id = 4, Name = "Mouse", Price = 89.90M, WarehouseId = 3 }
        );
        
        
    }
}

