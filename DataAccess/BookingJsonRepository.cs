using BusinessContractors;
using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BookingJsonRepository : IBookingJsonRepository
    {
        private const string PATH = "..\\..\\..\\..\\DataAccess\\Data\\booking.json";

        private async Task<JsonBooking> GetSavedBookingsAsync(CancellationToken cancellationToken)
        {
            JsonBooking jsonBooking = null;

            if(!File.Exists(PATH))
            {
                jsonBooking = new JsonBooking();
            }
            else
            {
                string savedBookings = GetSaveBookings();
                jsonBooking = JsonConvert.DeserializeObject<JsonBooking>(savedBookings);
            }

            return jsonBooking;
        }

        private string GetSaveBookings()
        {
            string savedBookings;


            using (var sr = new StreamReader(PATH))
            {
                savedBookings = sr.ReadToEnd();
            }
            return savedBookings;
        }

        private void AddBooking(JsonBooking jsonBooking, Booking booking)
        {
            if(jsonBooking?.Bookings == null)
            {
                throw new ArgumentNullException(nameof(jsonBooking), "invalid saved bookings");
            }

            var lastSavedId = jsonBooking.Bookings.Count == 0 ? 0 : jsonBooking.Bookings.Max(booking => booking.Id);
            booking.Id = lastSavedId + 1;

            jsonBooking.Bookings.Add(booking);
        }

        private async void SaveBookings(JsonBooking jsonBooking, CancellationToken cancellationToken)
        {
            if (jsonBooking?.Bookings == null) throw new ArgumentNullException(nameof(jsonBooking), "Invalid saved bookings");

            var jsonBookings = JsonConvert.SerializeObject(jsonBooking);

            await using (var fs = new StreamWriter(PATH, false))
            {
                await fs.WriteAsync(new StringBuilder(jsonBookings), cancellationToken);
            }
        }
       
        public async Task<Booking> CreateBookingAsync(Booking booking, CancellationToken cancellationToken)
        {
            if (booking == null)
            {
                throw new ArgumentNullException(nameof(booking), "Invalid booking");
            }

            //var path = "..\\..\\..\\..\\DataAccess\\Data\\booking.json";
            ////List<Booking> bookings;
            //JsonBooking jsonBooking;

            //if (!File.Exists(path))
            //{
            //    //bookings = new List<Booking> { booking };
            //    jsonBooking = new JsonBooking();
            //    booking.Id = 1;
            //    jsonBooking.Bookings.Add(booking);
            //}
            //else
            //{
            //string savedBookings;
            //using(var sr = new StreamReader(path))
            //{
            //    savedBookings = sr.ReadToEnd();
            //}
            ////bookings = JsonConvert.DeserializeObject<List<Booking>>(savedBookings);
            ////bookings.Add(booking);
            //jsonBooking = JsonConvert.DeserializeObject<JsonBooking>(savedBookings);
            //jsonBooking = GetBookings();
            //booking.Id = jsonBooking.Bookings.Count == 0 ? 1 : jsonBooking.Bookings.Max(booking => booking.Id) + 1;
            //jsonBooking.Bookings.Add(booking);
            //}
            //var jsonBookings = JsonConvert.SerializeObject(bookings);
            //var jsonBookings = JsonConvert.SerializeObject(jsonBooking);
            //using (var fs = new StreamWriter(PATH, false))
            //{
            //    fs.Write(jsonBookings);
            //}
            var savedBookings = await this.GetSavedBookingsAsync(cancellationToken);
            this.AddBooking(savedBookings, booking);
            this.SaveBookings(savedBookings, cancellationToken);

            return booking;
        }

        public async Task<List<Booking>> GetAllBookingsAsync(CancellationToken cancellationToken)
        {
            var savedBookings = await this.GetSavedBookingsAsync(cancellationToken);
            if (savedBookings?.Bookings == null)
            {
                throw new ArgumentNullException(nameof(savedBookings), "invalid saved bookings");
            }
            return savedBookings.Bookings;
        }

        //public List<Booking> GetBookingsByPassengerSurname(string surname)
        //{
        //    var savedBookings = this.GetSavedBookings().Bookings;
        //    if (savedBookings == null)
        //    {
        //        throw new ArgumentNullException(nameof(savedBookings), "invalid saved bookings");
        //    }
        //    var filteredBookings = savedBookings.Where(b => b.Surname == surname).ToList();
        //    return filteredBookings;
        //}

        //public List<Booking> GetBookingsByDepartureStation(string station)
        //{
        //    var savedBookings = this.GetSavedBookings().Bookings;
        //    if (savedBookings == null)
        //    {
        //        throw new ArgumentNullException(nameof(savedBookings), "invalid saved bookings");
        //    }
        //    var filteredBookings = savedBookings.Where(b => b.DepartureStation == station).ToList();
        //    return filteredBookings;
        //}

        public async Task<Booking> GetBookingById(int id, CancellationToken cancellationToken)
        {
            var savedBookings = await this.GetSavedBookingsAsync(cancellationToken);
            if (savedBookings == null)
            {
                throw new ArgumentNullException(nameof(savedBookings), "invalid saved bookings");
            }
            var booking = savedBookings.Bookings.FirstOrDefault(b => b.Id == id);

            return booking;
        }

        public async Task<Booking> UpdateBookingAsync(DeleteUpdateBookingCommand command, CancellationToken cancellationToken)
        {
            var savedBookings = await this.GetSavedBookingsAsync(cancellationToken);
            var b = savedBookings.Bookings.FirstOrDefault(b => b.Id == command.Id);
            if (b == null || b.Id != command.Id)
            {
                throw new InvalidOperationException("Booking not found");
            }

            b.DepartureStation = command.DepartureStation;
            b.ArrivalStation = command.ArrivalStation;
            b.Name = command.Name;
            b.Surname = command.Surname;

            this.SaveBookings(savedBookings, cancellationToken);

            return b;
        }

        public async Task<bool> DeleteBookingByIdAsync(int id, CancellationToken cancellationToken)
        {
            var savedBookings = await this.GetSavedBookingsAsync(cancellationToken);
            var b = savedBookings.Bookings.FirstOrDefault(b => b.Id == id);
            if(b == null)
            {
                throw new InvalidOperationException("Booking not found");
            }
            bool isRemoved = savedBookings.Bookings.Remove(b);
            this.SaveBookings(savedBookings, cancellationToken);

            return isRemoved;
        }
    }
}
