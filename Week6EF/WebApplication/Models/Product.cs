using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplicationEF.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int WarehouseId { get; set; }

    [JsonIgnore]
    public virtual Warehouse Warehouse { get; set; } = null!;
}

