using BusinessContractors;
using Entity;
using System.Xml.Linq;

namespace Business
{
    public class BookingConverter : IBookingConverter
    {
        public BookingDto GetDto(Booking booking)
        {
            if(booking == null)
            {
                throw new ArgumentNullException(nameof(booking), "Invalid bookig");
            }

            BookingDto dto = new BookingDto(
                booking.Id,
                booking.DepartureStation,
                booking.ArrivalStation,
                booking.Name,
                booking.Surname);

            return dto;
        }

        public Booking GetModel(BookingDto bookingDto)
        {
            if (bookingDto == null)
            {
                throw new ArgumentNullException(nameof(bookingDto), "Invalid bookig");
            }

            Booking booking = new Booking(
                default,
                bookingDto.DepartureStation,
                bookingDto.ArrivalStation,
                bookingDto.Name,
                bookingDto.Surname);

            return booking;
        }
    }
}
