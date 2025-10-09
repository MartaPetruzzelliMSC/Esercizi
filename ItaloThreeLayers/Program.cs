using Business;
using DataAccess;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Presentation;

namespace ItaloThreeLayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var applicationBuilder = Host.CreateApplicationBuilder();
            applicationBuilder.Services.AddTransient<IBookingJsonRepository, BookingJsonRepository>();
            applicationBuilder.Services.AddTransient<IStationRepository, StationJsonRepository>();
            applicationBuilder.Services.AddSingleton<IBookingConverter, BookingConverter>();
            applicationBuilder.Services.AddSingleton<IBookingService, BookingService>();
            applicationBuilder.Services.AddSingleton<IConsoleView, ConsoleView>();

            using var host = applicationBuilder.Build();
            using IServiceScope serviceScope = host.Services.CreateScope();
            //IBookingRepository bookingRepository = new BookingRepository();
            //IBookingConverter bookingConverter = new BookingConverter();
            //IBookingService bookingService = new BookingService(bookingRepository, bookingConverter);
            var consoleView = serviceScope.ServiceProvider.GetService<IConsoleView>();
            if(consoleView != null)
            {
                consoleView.ShowMenu();
            }

        }
    }
}
