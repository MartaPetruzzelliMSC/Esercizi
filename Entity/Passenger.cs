using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Passenger
    {
        public Passenger(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Bookings = new List<Booking>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Booking> Bookings { get; set; }

    }
}
