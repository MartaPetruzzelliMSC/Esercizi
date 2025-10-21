using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstExample.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }

    // Foreign key
    public int WarehouseId { get; set; }
}
