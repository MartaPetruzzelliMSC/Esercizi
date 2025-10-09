using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Platforms { get; set; }
        public string IsTerminaStation { get; set; }
        public bool IsActive { get; set; }
    }
}
