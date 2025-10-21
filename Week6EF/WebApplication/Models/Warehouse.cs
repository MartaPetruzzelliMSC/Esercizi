using System;
using System.Collections.Generic;

namespace WebApplicationEF.Models;

public partial class Warehouse
{
    public int Id { get; set; }

    public string Location { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
