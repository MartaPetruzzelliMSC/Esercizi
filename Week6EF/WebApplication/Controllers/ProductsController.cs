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

    // GET: api/products/structure
    [HttpGet("structure")]
    public async Task<ActionResult<IEnumerable<ProductStructureDto>>> GetProductsStructure()
    {
        var query = _context.Products.AsNoTracking().Include(p => p.Comments)
       .Select(x => new ProductStructureDto
       {
           Id = x.Id,
           Name = x.Name,
           Price = x.Price,
           WarehouseId = x.WarehouseId,
           Comments = x.Comments.Select(p => new CommentDto
           {
               Id = p.Id,
               CommentContent = p.CommentContent,
               CreatedAt = p.CreatedAt,
               ProductId = p.ProductId
           })
       });

        var sql = query.ToQueryString();

        return await query.ToListAsync();
    } 
    
    // GET: api/products
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
    {
        var query = _context.Products.AsNoTracking().Include(p => p.Comments)
       .Select(x => new ProductDto
       {
           Id = x.Id,
           Name = x.Name,
           Price = x.Price,
           WarehouseId = x.WarehouseId,
       });

        var sql = query.ToQueryString();

        return await query.ToListAsync();
    }

    // GET: api/products/5/structure
    [HttpGet("{id}/structure")]
    public async Task<ActionResult<ProductStructureDto>> GetProductStructure(int id)
    {
        var product = await _context.Products
           .Include(p => p.Comments)
           .Select(x => new ProductStructureDto
           {
               Id = x.Id,
               Name = x.Name,
               Price = x.Price,
               WarehouseId = x.WarehouseId,
               Comments = x.Comments.Select(p => new CommentDto
               {
                   Id = p.Id,
                   CommentContent = p.CommentContent,
                   CreatedAt = p.CreatedAt,
                   ProductId = p.ProductId
               })
           }).Where(x => x.Id == id).FirstOrDefaultAsync();
        
        if (product == null) 
            return NotFound();

        return product;
    }
    
    // GET: api/products/5
    [HttpGet("{id}")]
    public async Task<ActionResult<ProductDto>> GetProduct(int id)
    {
        var product = await _context.Products.AsNoTracking()
           .Select(x => new ProductDto
           {
               Id = x.Id,
               Name = x.Name,
               Price = x.Price,
               WarehouseId = x.WarehouseId,
               
           }).Where(x => x.Id == id).FirstOrDefaultAsync();
        
        if (product == null) 
            return NotFound();

        return product;
    }

    // GET: api/products/4/comments
    [HttpGet("{id}/comments")]
    public async Task<ActionResult<IEnumerable<CommentDto>>> GetCommentsByProductId(int id)
    {
        var p = await GetProduct(id);
        if (p == null)
            return BadRequest($"Product with ID {id} does not exist.");
        var c = await _context.Comments.AsNoTracking()
            .Select(x => new CommentDto
            {
                Id = x.Id,
                CommentContent = x.CommentContent,
                CreatedAt = x.CreatedAt,
                ProductId = x.ProductId
            }).Where(x => x.ProductId == id).ToListAsync();

        return c;
    }

    // POST: api/products
    [HttpPost]
    public async Task<ActionResult<ProductDto>> CreateProduct(UpsertProductDto product)
    {
        var warehouseExists = await _context.Warehouses
            .AnyAsync(w => w.Id == product.WarehouseId);
        if (!warehouseExists)
            return BadRequest($"Warehouse with ID {product.WarehouseId} does not exist.");

        var p = _context.Products.Add(new Product
        {
            Name = product.Name,
            Price = product.Price,
            WarehouseId = product.WarehouseId,
        }).Entity;
        await _context.SaveChangesAsync();

        //return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        //return Ok();
        return new ProductDto
        {
            Id = p.Id,
            Name = p.Name,
            Price = p.Price,
            WarehouseId = p.WarehouseId
        };
    }

    // PUT: api/products/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, UpsertProductDto updatedProduct)
    {
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
