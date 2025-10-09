using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessContractors
{
    public class CreateBookingCommand
    {
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
