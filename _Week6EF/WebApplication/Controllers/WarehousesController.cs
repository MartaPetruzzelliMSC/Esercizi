using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    // GET: api/warehouses
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Warehouse>>> GetWarehouses()
    {
        return await _context.Warehouses.Include(x => x.Products).ToListAsync();
    }

    // GET: api/warehouses/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Warehouse>> GetWarehouse(int id)
    {
        var warehouse = await _context.Warehouses.FindAsync(id);

        if (warehouse == null)
            return NotFound();

        return warehouse;
    }


    // GET: api/warehouses/5/products
    [HttpGet("{id}/products")]
    public async Task<ActionResult<IEnumerable<Product>>> GetProductsByWarehouse(int id)
    {
        var warehouseExists = await _context.Warehouses.AnyAsync(w => w.Id == id);
        if (!warehouseExists)
            return NotFound();

        var products = await _context.Products
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
    public async Task<ActionResult<Warehouse>> CreateWarehouse(Warehouse warehouse)
    {
        _context.Warehouses.Add(warehouse);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetWarehouse), new { id = warehouse.Id }, warehouse);
    }

    // PUT: api/warehouses/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateWarehouse(int id, Warehouse updatedWarehouse)
    {
        if (id != updatedWarehouse.Id)
            return BadRequest();

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
