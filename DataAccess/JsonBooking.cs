using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class JsonBooking
    {
        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
