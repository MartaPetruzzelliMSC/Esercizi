using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationEF.Dtos;
using WebApplicationEF.Models;

namespace WebApplicationEF.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly DatabaseFirstDbContext _context;

    public ProductsController(DatabaseFirstDbContext context)
    {
        _context = context;
    }

    // GET: api/products
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
    {
        var query = _context.Products.AsNoTracking()
            .Include(p => p.Warehouse); // Include related Warehouse data

        var sql = query.ToQueryString();

        return await query.ToListAsync();
    }

    // GET: api/products/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        var product = await _context.Products.AsNoTracking()
            .Include(p => p.Warehouse)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (product == null)
            return NotFound();

        return product;
    }

    // POST: api/products
    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct(Product product)
    {
        var warehouseExists = await _context.Warehouses
            .AnyAsync(w => w.Id == product.WarehouseId);
        if (!warehouseExists)
            return BadRequest($"Warehouse with ID {product.WarehouseId} does not exist.");

        _context.Products.Add(product);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
    }

    // PUT: api/products/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, ProductDto updatedProduct)
    {
        if (id <= 0)
            return BadRequest();

        var existingProduct = await _context.Products
        .Include(p => p.Warehouse)
        .FirstOrDefaultAsync(p => p.Id == id);

        if (existingProduct == null)
            return NotFound();

        var warehouse = await _context.Warehouses.FindAsync(updatedProduct.WarehouseId);
        if (warehouse == null)
            return BadRequest($"Warehouse with ID {updatedProduct.WarehouseId} does not exist.");

        existingProduct.Name = updatedProduct.Name;
        existingProduct.Price = updatedProduct.Price;
        existingProduct.WarehouseId = updatedProduct.WarehouseId;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    // DELETE: api/products/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
            return NotFound();

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
