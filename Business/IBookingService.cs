using BusinessContractors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IBookingService
    {
        Task<BookingDto> CreateBookingAsync(CreateBookingCommand command, CancellationToken cancellationToken);

        Task<List<BookingDto>> GetAllBookingsAsync(CancellationToken cancellationToken);

        Task<bool> DeleteBookingByIdAsync(int id, CancellationToken cancellationTolen);
        
        Task<BookingDto> UpdateBookingAsync(DeleteUpdateBookingCommand duCommand, CancellationToken cancellationToken);
    }
}
