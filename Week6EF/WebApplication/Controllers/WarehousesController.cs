using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationEF.Dtos;
using WebApplicationEF.Models;

namespace WebApplicationEF.Controllers;

[ApiController]
[Route("[controller]")]
public class WarehousesController : ControllerBase
{
    private readonly DatabaseFirstDbContext _context;

    public WarehousesController(DatabaseFirstDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<WarehouseDto>>> GetWarehouses()
    {
        var w = _context.Warehouses
            .Select(x => new WarehouseDto
            {
                Id = x.Id,
                Location = x.Location,               
            });

        var sql = w.ToQueryString();
        return await w.ToListAsync();
    }

    // GET: api/warehouses/structure
    [HttpGet("structure")]
    public async Task<ActionResult<IEnumerable<WarehouseStructureDto>>> GetWarehousesStructure()
    {
        var w = _context.Warehouses
            .Include(x => x.Products)
            .ThenInclude(y => y.Comments)
            .Select(x => new WarehouseStructureDto
            {
                Id = x.Id,
                Location = x.Location,
                ProductDtos = x.Products.Select(p => new ProductStructureDto
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Price = p.Price,
                        WarehouseId = p.WarehouseId,
                        Comments = p.Comments.Select(c => new CommentDto
                        {
                            Id = c.Id,
                            CommentContent = c.CommentContent,
                            CreatedAt = c.CreatedAt,
                            ProductId = c.ProductId
                        })
                })
            });

        var sql = w.ToQueryString();

        //  SELECT [w].[Id], [w].[Location], [s].[Id], [s].[Name], [s].[Price], [s].[WarehouseId], [s].[Id0], [s].[CommentContent], [s].[CreatedAt], [s].[ProductId]
        //  FROM [Warehouse] AS [w]
        //  LEFT JOIN (
        //  SELECT [p].[Id], [p].[Name], [p].[Price], [p].[WarehouseId], [c].[Id] AS [Id0], [c].[CommentContent], [c].[CreatedAt], [c].[ProductId]
        //  FROM [Product] AS [p]
        //  LEFT JOIN [Comment] AS [c] ON [p].[Id] = [c].[ProductId]
        //  ) AS [s] ON [w].[Id] = [s].[WarehouseId]
        //  ORDER BY [w].[Id], [s].[Id]

        return await w.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<WarehouseDto>> GetWarehouse()
    {
        var w = _context.Warehouses
            .Select(x => new WarehouseDto
            {
                Id = x.Id,
                Location = x.Location,
            });

        var sql = w.ToQueryString();
        return await w.FirstOrDefaultAsync();
    }

    // GET: api/warehouses/1/structure
    [HttpGet("{id}/structure")]
    public async Task<ActionResult<WarehouseStructureDto>> GetWarehouseStructure(int id)
    {
        var warehouse = await _context.Warehouses
            .Include(x => x.Products)
            .Select(x => new WarehouseStructureDto
            {
                Id = x.Id,
                Location = x.Location,
                ProductDtos = x.Products.Select(p => new ProductStructureDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    WarehouseId = p.WarehouseId
                })
            }).Where(x => x.Id == id).FirstAsync();

        if (warehouse == null)
            return NotFound();

        return warehouse;
    }

    // GET: api/warehouses/5/products
    [HttpGet("{id}/products")]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetProductsByWarehouse(int id)
    {
        var warehouseExists = await _context.Warehouses.AnyAsync(w => w.Id == id);
        if (!warehouseExists)
            return NotFound();

        var products = await _context.Products.AsNoTracking()
            .Select(x => new ProductDto
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                WarehouseId = x.WarehouseId,
            })
            .Where(p => p.WarehouseId == id)
            .ToListAsync();

        return products;
    }


    // POST: api/warehouses/{id}/products
    [HttpPost("{id}/products")]
    public async Task<ActionResult<Product>> CreateProductForWarehouse(int id, Product product)
    {
        var warehouse = await _context.Warehouses.FindAsync(id);
        if (warehouse == null)
            return NotFound($"Warehouse with ID {id} not found.");

        product.WarehouseId = id;

        _context.Products.Add(product);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetProductsByWarehouse), new { id = id }, product);
    }


    // POST: api/warehouses
    [HttpPost]
    public async Task<ActionResult<WarehouseDto>> CreateWarehouse(UpsertWarehouseDto warehouse)
    {
        
        var w = _context.Warehouses.Add( new Warehouse
        {
            Location = warehouse.Location
            //Products = warehouse.ProductDto
        }).Entity;
        await _context.SaveChangesAsync();

        return new WarehouseDto
        {
            Id = w.Id,
            Location = w.Location,
        };
    }

    // PUT: api/warehouses/
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateWarehouse(int id, UpsertWarehouseDto updatedWarehouse)
    {
        //if (id != updatedWarehouse.Id)
        //    return BadRequest();

        var existingWarehouse = await _context.Warehouses.FindAsync(id);
        if (existingWarehouse == null)
            return NotFound();

        existingWarehouse.Location = updatedWarehouse.Location;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    // DELETE: api/warehouses/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteWarehouse(int id)
    {
        var warehouse = await _context.Warehouses.FindAsync(id);
        if (warehouse == null)
            return NotFound();

        _context.Warehouses.Remove(warehouse);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
