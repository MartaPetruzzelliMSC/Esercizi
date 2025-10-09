using BusinessContractors;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IBookingRepository
    {
        Booking CreateBooking(Booking booking);

        List<Booking> GetAllBookings();

        Booking UpdateBooking(DeleteUpdateBookingCommand command);

        bool DeleteBookingById(int id);

        Booking GetBookingById(int id);
    }
}
