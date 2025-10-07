using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IBookingConverter
    {
        BookingDto GetDto(Booking booking);
        Booking GetModel(BookingDto bookingDto);
    }
}
