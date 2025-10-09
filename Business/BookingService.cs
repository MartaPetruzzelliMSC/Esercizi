using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using BusinessContractors;
using DataAccess;
using Entity;

namespace Business
{
    public class BookingService : IBookingService
    {
        private readonly IBookingJsonRepository bookingRepository;
        private readonly IBookingConverter bookingConverter;

        public BookingService(IBookingJsonRepository bookingRepository, IBookingConverter bookingConverter)
        {
            if (bookingRepository == null)
            {
                throw new ArgumentNullException(nameof(bookingRepository), "No repository found");
            }
            this.bookingConverter = bookingConverter ?? throw new ArgumentNullException();

            this.bookingRepository = bookingRepository;
        }

        public async Task<BookingDto> CreateBookingAsync(CreateBookingCommand command, CancellationToken cancellationToken)
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

            var model = await this.bookingRepository.CreateBookingAsync(inputModel, cancellationToken);
            var dto = bookingConverter.GetDto(model);
            return dto;
        }

        public async Task<bool> DeleteBookingByIdAsync(int id, CancellationToken cancellationToken)
        {
            bool delete = await this.bookingRepository.DeleteBookingByIdAsync(id, cancellationToken);
            return delete;
        }

        public async Task<List<BookingDto>> GetAllBookingsAsync(CancellationToken cancellationToken)
        {
            var bookingsList = await this.bookingRepository.GetAllBookingsAsync(cancellationToken);
            var bookingsDto = bookingsList.Select(b => this.bookingConverter.GetDto(b)).ToList();
            
            return bookingsDto;
        }

        public async Task<BookingDto> UpdateBookingAsync(DeleteUpdateBookingCommand duCommand, CancellationToken cancellationToken)
        {
            BookingDto dto = this.bookingConverter.GetDto(await this.bookingRepository.UpdateBookingAsync(duCommand, cancellationToken));
            return dto;
        }
    }
}
