using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BookingCommand
    {
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
