namespace CodeFirstExample.Models;

/*
 Nel caso di una creazione completa non usare migrazioni, ma solo EnsureCreated.

 Nel caso di creazione di una nuova relazione, eseguire i seguenti comandi nella Package Manager Console:

 Add-Migration AddWarehouseRelation
 Update-Database
*/


public class Warehouse
{
    public int Id { get; set; }
    public string Location { get; set; }

    // Navigazione inversa
    public List<Product> Products { get; set; } = new();

    //Foreing Key
    public int CountryId { get; set; }
}
