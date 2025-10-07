using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BookingJsonRepository : IBookingRepository
    {
        
        public Booking CreateBooking(Booking booking)
        {
            if (booking == null)
            {
                throw new ArgumentNullException(nameof(booking), "Invalid booking");
            }

            var path = "..\\..\\..\\..\\DataAccess\\Data\\booking.json";
            //List<Booking> bookings;
            JsonBooking jsonBooking;

            if (!File.Exists(path))
            {
                //bookings = new List<Booking> { booking };
                jsonBooking = new JsonBooking();
                booking.Id = 1;
                jsonBooking.Bookings.Add(booking);
            }
            else
            {
                string savedBookings;
                using(var sr = new StreamReader(path))
                {
                    savedBookings = sr.ReadToEnd();
                }
                //bookings = JsonConvert.DeserializeObject<List<Booking>>(savedBookings);
                //bookings.Add(booking);
                jsonBooking = JsonConvert.DeserializeObject<JsonBooking>(savedBookings);
                booking.Id = jsonBooking.Bookings.Max(booking => booking.Id) + 1;
                jsonBooking.Bookings.Add(booking);
            }
            //var jsonBookings = JsonConvert.SerializeObject(bookings);
            var jsonBookings = JsonConvert.SerializeObject(jsonBooking);
            using (var fs = new StreamWriter(path, false))
            {
                fs.Write(jsonBookings);
            }

            return booking;
            

        }
    }
}
