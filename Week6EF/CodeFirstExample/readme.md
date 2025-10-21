# Esempio Code First 
Questo readme spiega come configurare il progetto ed eseguire le Migrations

## Creare e configurare il progetto
> Per la creazione e la configurazione possiamo usare Visual Studio oppure la **CLI** *(PowerShell / Terminale)*

1. **Creazione del progetto (in questo caso Console)**
> Per creare un progetto api backend basta sostituire **console** con *webapi**
```terminal
dotnet new console --framework net8.0
```

**Spiegazione:**
- **dotnet new**: Comando per creare un nuovo progetto.
- **console**: Specifica il tipo di progetto (applicazione console).
- **--framework net8.0**: Indica la versione del framework .NET da utilizzare (in questo caso .NET 8.0).

2. **Aggiungere le dipendenze a Entity Framework Core**
> Possiamo usare le utility di ***NuGet Package Manager*** oppure la ***CLI*** *(powershell / Terminale)*
Per usare i **NuGet tools** possiamo trovare il comando in visual studio '*>Tools>NuGet Package Manager>Manage NuGet Package for Solution ...'* oppure *'Package Manager Console'*

```powershell
# powershell
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```
oppure
```bash
# Package Manager Console
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
```

## Configurazione e creazione DataContext e Models

1. **La stringa di connessione al database**
>Importante aggiungere questa configurazione al file *appsettings.js* per centralizzare l'accesso e rendere sicura la stringa di connessione al database
*appsettings.js*:
```json
{
  "AppSettings": {
    "ConnectionStrings": {
      "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=Week_6EF_DB;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
  }
}
```

2. **Aggiungere la configurazione al builder dell' applicazione**
> Se non è stato ancora creato creare prima il *DataContext (punto 4)* e le *Entities (punto 3)*
``` csharp
var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
    })
    .ConfigureServices((context, services) =>
    {
        var config = context.Configuration;
        services.Configure<AppSettings>(context.Configuration.GetSection("AppSettings"));
        var connectionString = config.GetSection("AppSettings:ConnectionStrings:DefaultConnection").Value;

        services.AddDbContext<CodeFirstDbContext>(options => options.UseSqlServer(connectionString));

        services.AddTransient<App>();
    })
    .Build();

var app = host.Services.GetRequiredService<App>();
app.Run();
```

3. **Creare le *Entities (classi)*.**

> Nella modalità Code First il codice è la *Source of Truth*. Creare una cartella **\Models** nel progetto e aggiungere queste due classi

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }

    // Foreign key
    public int WarehouseId { get; set; }
}

public class Warehouse
{
    public int Id { get; set; }
    public string Location { get; set; }

    // Navigazione inversa
    public List<Product> Products { get; set; } = new();
}
```

4. **Creare il *DataContext*.**

> Creare una cartella **\Data** nel progetto e aggiungere questa classe

```csharp
using Microsoft.EntityFrameworkCore;

public class CodeFirstDbContext : DbContext
{
    public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed dei magazzini
        modelBuilder.Entity<Warehouse>().HasData(
            new Warehouse { Id = 1, Location = "Torino" },
            new Warehouse { Id = 2, Location = "Genova" }
        );

        // Seed dei prodotti
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Monitor", Price = 199.99M, WarehouseId = 1 },
            new Product { Id = 2, Name = "Tastiera", Price = 49.99M, WarehouseId = 1 },
            new Product { Id = 3, Name = "Stampante", Price = 129.50M, WarehouseId = 2 }
        );
    }
}

```

## Migrations e Update Database

1. **Prima Migrazione**
> Creare il database e le tabelle partendo dalle classi in *\Models*
```powershell
## powershell

dotnet ef migrations add InitialCreate
dotnet ef database update
```
oppure
```bash
# Package Manager Console
Add-Migration InitialCreate
Update-Database
```

2. **Migrazioni successive**
> Modificando o aggiundendo le classi in Models possiamo applicare le migrations usando queste istruzioni 
>
> **Importante dare un nome contestualizzato** e **comprensibile** 
```powershell
## powershell
dotnet ef migrations add AddColumnCreationDate
dotnet ef database update
```
oppure
```bash
# Package Manager Console
Add-Migration AddColumnCreationDate
Update-Database
```

Possiamo verificare le migrations usando l'istruzione: ***Get-Migration*** usando la Package Manager Console oppure ***dotnet ef migrations list*** su powershell