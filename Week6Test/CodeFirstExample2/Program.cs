using CodeFirstExample2;
using CodeFirstExample2.Configuration;
using CodeFirstExample2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//namespace CodeFirstExample2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }


//    }
//}

var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
    })
    .ConfigureServices((context, services) =>
    {
        var config = context.Configuration;
        services.Configure<AppSettings>(context.Configuration.GetSection("Appsettings"));
        var connectionString = config.GetSection("AppSettings:ConnectionStrings:DefaultConnection").Value;

        services.AddDbContext<CodeFirstDbContext>(options => options.UseSqlServer(connectionString));

        services.AddTransient<App>();
    })
    .Build();

var app = host.Services.GetRequiredService<App>();
app.Run();


