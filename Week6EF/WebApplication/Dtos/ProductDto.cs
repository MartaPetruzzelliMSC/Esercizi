using WebApplicationEF.Models;

namespace WebApplicationEF.Dtos;


public class ProductDto
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int WarehouseId { get; set; }

    public static ProductDto GetDto(Product p)
    {
        return new ProductDto
        {
            Name = p.Name,
            Price = p.Price,
            WarehouseId = p.WarehouseId
        };
    }
}

