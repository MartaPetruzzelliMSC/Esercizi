using WebApplicationEF.Models;

namespace WebApplicationEF.Dtos;


public class ProductStructureDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int WarehouseId { get; set; }
    public IEnumerable<CommentDto>? Comments { get; set; }

}

