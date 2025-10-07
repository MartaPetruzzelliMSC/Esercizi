using Entity;

namespace DataAccess
{
    public class BookingRepository : IBookingRepository
    {
        private List<Booking> Bookings { get; }

        public BookingRepository()
        {
            this.Bookings = new List<Booking>();
        }
        public Booking CreateBooking(Booking booking)
        {
            if(booking == null)
            {
                throw new ArgumentNullException(nameof(booking), "Invalid booking");
            }

            booking.Id = GetNewId();
            Bookings.Add(booking);

            return booking;
        }
        
        private int GetNewId()
        {
            if(Bookings.Count == 0)
            {
                return 0;
            }
            var id = Bookings.Max(booking => booking.Id);
            return id + 1;
        }
    }
}
