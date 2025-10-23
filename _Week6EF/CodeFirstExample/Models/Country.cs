using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigazione Inversa
        public List<Warehouse> Warehouses { get; set; } = new();
    }
}
