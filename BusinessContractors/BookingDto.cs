using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessContractors
{
    public class BookingDto
    {
        public BookingDto(int id, string departureStation, string arrivalStation, 
            string name, string surname)
        {
            Id = id;
            DepartureStation = departureStation;
            ArrivalStation = arrivalStation;
            Name = name;
            Surname = surname;
        }

        public int Id { get; private set; }
        public string DepartureStation { get; private set; }
        public string ArrivalStation { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
    }
}
