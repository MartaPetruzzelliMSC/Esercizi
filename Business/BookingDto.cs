using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BookingDto
    {
        public BookingDto(string departureStation, string arrivalStation, 
            string name, string surname)
        {
            DepartureStation = departureStation;
            ArrivalStation = arrivalStation;
            Name = name;
            Surname = surname;
        }

        public string DepartureStation { get; private set; }
        public string ArrivalStation { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
    }
}
