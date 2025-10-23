using System;
using System.Collections.Generic;

namespace WebApplicationEF.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int WarehouseId { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual Warehouse Warehouse { get; set; } = null!;
}
