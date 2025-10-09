using BusinessContractors;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IBookingJsonRepository
    {
        Task<Booking> CreateBookingAsync(Booking booking, CancellationToken cancellationToken);
        Task<bool> DeleteBookingByIdAsync(int id, CancellationToken cancellationToken);
        Task<List<Booking>> GetAllBookingsAsync(CancellationToken cancellationToken);
        Task<Booking> UpdateBookingAsync(DeleteUpdateBookingCommand command, CancellationToken cancellationToken);
    }
}
