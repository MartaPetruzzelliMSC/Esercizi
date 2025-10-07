using Business;

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

        private void ShowBookings()
        {
            if(this.dto == null)
            {
                Console.WriteLine("Error while saving the booking");
                return;
            }
            Console.WriteLine("Booling saved Succesfully");
            Console.WriteLine($"{this.dto.DepartureStation} - {this.dto.ArrivalStation} for {this.dto.Surname} {this.dto.Name}");
            this.dto = null;
        }

        public void ShowMenu()
        {
            var exit = false;

            do
            {
                Console.WriteLine("======================= Menu =======================");
                Console.WriteLine("0) Exit \n1) Create booking");
                var chosenFunctionality = Console.ReadLine();
                if(chosenFunctionality == "0")
                {
                    exit = true;
                    break;
                }
                else if (chosenFunctionality != "1")
                {
                    Console.WriteLine("Invalid choice");
                    break;
                }

                Console.Write("Insert departure station: ");
                var departure = Console.ReadLine();
                Console.Write("Insert arrival station: ");
                var arrival = Console.ReadLine();
                Console.Write("Insert passenger name: ");
                var name = Console.ReadLine();
                Console.Write("Insert passenger surname: ");
                var surname = Console.ReadLine();

                var command = new BookingCommand
                {
                    DepartureStation = departure,
                    ArrivalStation = arrival,
                    Name = name,
                    Surname = surname
                };

                this.dto = this.bookingService.CreateBooking(command);
                this.ShowBookings();
            } while (!exit);
            
            Environment.Exit(0);
        }
    }
}
