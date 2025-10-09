using BusinessContractors;
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
                return 1;
            }
            var id = Bookings.Max(booking => booking.Id);
            return id + 1;
        }

        public List<Booking> GetAllBookings()
        {
            return Bookings;
        }
        public Booking GetBookingById(int id)
        {
            var booking = Bookings.FirstOrDefault(b => b.Id == id);
            return booking;
        }

        public Booking UpdateBooking(DeleteUpdateBookingCommand command)
        {
            var b = GetBookingById(command.Id);
            if (b == null || b.Id != command.Id)
            {
                throw new InvalidOperationException("Booking not found");
            }

            b.DepartureStation = command.DepartureStation;
            b.ArrivalStation = command.ArrivalStation;
            b.Name = command.Name;
            b.Surname = command.Surname;

            return b;
        }

        public bool DeleteBookingById(int id)
        {
            var booking = GetBookingById(id);
            if(booking == null)
            {
                throw new InvalidOperationException("Booking not found");
            }
            
            return Bookings.Remove(booking);
        }
    }
}
