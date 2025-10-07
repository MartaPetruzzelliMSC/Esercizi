using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;

namespace Business
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository bookingRepository;
        private readonly IBookingConverter bookingConverter;

        public BookingService(IBookingRepository bookingRepository, IBookingConverter bookingConverter)
        {
            if (bookingRepository == null)
            {
                throw new ArgumentNullException(nameof(bookingRepository), "No repository found");
            }

            this.bookingRepository = bookingRepository;
            this.bookingConverter = bookingConverter;
        }

        public BookingDto CreateBooking(BookingCommand command)
        {
            if(command == null)
            {
                throw new ArgumentNullException(nameof(command), "Invalid command");
            }

            var inputModel = new Booking(
                default,
                command.DepartureStation,
                command.ArrivalStation,
                command.Name,
                command.Surname);

            var model = this.bookingRepository.CreateBooking(inputModel);
            var dto = bookingConverter.GetDto(model);
            return dto;
        }


    }
}
