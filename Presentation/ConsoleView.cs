using Business;
using BusinessContractors;
using System.Security.Cryptography;

namespace Presentation
{
    public class ConsoleView : IConsoleView
    {
        private readonly IBookingService bookingService;
        private BookingDto dto;

        public ConsoleView(IBookingService bookingService)
        {
            if(bookingService == null)
            {
                throw new ArgumentNullException();
            }
            this.bookingService = bookingService;
        }

        public async Task ShowMenu()
        {
            var exit = false;

            do
            {
                Console.WriteLine("======================= Menu =======================");
                Console.WriteLine("0) Exit \n1) Create booking \n2) Get all bookings \n3) Update Booking \n4) Delete booking");
                var chosenFunctionality = Console.ReadLine();
                switch (chosenFunctionality)
                {
                    case "0":
                        exit = true;
                        break;
                    case "1":
                        await this.DoCreateFlow();
                        break;
                    case "2":
                        await this.DoGetFlow();
                        break;
                    case "3":
                        await this.DoUpdateFlow();
                        break;
                    case "4":
                        await this.DoDeleteFlow();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
                
            } while (!exit);
            
            Environment.Exit(0);
        }
       

        private void ShowBookings(BookingDto dto)
        {
            Console.WriteLine($"{dto.DepartureStation} - {dto.ArrivalStation} for {dto.Surname} {dto.Name}");
            dto = null;
        }

        private static (string departure, string arrival, string name, string surname) GetSaveParameters()
        {
            Console.Write("Insert departure station: ");
            var departure = Console.ReadLine();
            Console.Write("Insert arrival station: ");
            var arrival = Console.ReadLine();
            Console.Write("Insert passenger name: ");
            var name = Console.ReadLine();
            Console.Write("Insert passenger surname: ");
            var surname = Console.ReadLine();
            
            return (departure, arrival, name, surname);
        }
        
        public async Task DoCreateFlow()
        {
            var (departure, arrival, name, surname) = GetSaveParameters();
            var command = new CreateBookingCommand
            {
                DepartureStation = departure,
                ArrivalStation = arrival,
                Name = name,
                Surname = surname
            };

            var dto = await this.bookingService.CreateBookingAsync(command, CancellationToken.None);
            if (dto == null)
            {
                Console.WriteLine("Error while saving the booking");
                return;
            }
            Console.WriteLine("Booking saved Succesfully");
            this.ShowBookings(dto);
        }

        private async Task DoDeleteFlow() 
        {
            Console.WriteLine("Insert the id of the booking you want to delete");
            var list = await this.bookingService.GetAllBookingsAsync(CancellationToken.None);
            foreach (var dto in list)
            {
                Console.Write($"\n {dto.Id}))");
                this.ShowBookings(dto);
            }
            string answer = Console.ReadLine();
            if (int.TryParse(answer, out int id))
            {
                try
                {
                    var result = await this.bookingService.DeleteBookingByIdAsync(id, CancellationToken.None);
                    Console.WriteLine("Booking deleted succesfully");
                }
                catch(InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private async Task DoGetFlow()
        {
            var dtoList = await this.bookingService.GetAllBookingsAsync(CancellationToken.None);
            foreach (var dto in dtoList)
            {
                this.ShowBookings(dto);
            }
        }

        private async Task DoUpdateFlow()
        {
            Console.WriteLine("specify booking id: ");
            var list = await this.bookingService.GetAllBookingsAsync(CancellationToken.None);
            foreach (var dto in list)
            {
                Console.Write($"\n {dto.Id})");
                this.ShowBookings(dto);
            }
            if (int.TryParse(Console.ReadLine(), out var updateId) && updateId > 0)
            {
                var (departure, arrival, name, surname) = GetSaveParameters();
                var command = new DeleteUpdateBookingCommand
                {
                    Id = updateId,
                    DepartureStation = departure,
                    ArrivalStation = arrival,
                    Name = name,
                    Surname = surname
                };
                try
                {
                    var updatedDto = await this.bookingService.UpdateBookingAsync(command, CancellationToken.None);
                    Console.WriteLine("Booking updated Succesfully");
                    this.ShowBookings(updatedDto);
                }
                catch(InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }
    }
}
