-- 1. Creazione del Database
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'DatabaseFirstDb')
BEGIN
    CREATE DATABASE [DatabaseFirstDb];
END
GO

-- 2. Selezione del contesto del database
USE [DatabaseFirstDb];
GO

-- 3. Creazione della tabella 'Warehouse' (Magazzino)
CREATE TABLE Warehouse (
    -- Corrisponde a: public int Id { get; set; }
    Id INT PRIMARY KEY IDENTITY(1,1), 
    
    -- Corrisponde a: public string Location { get; set; }
    Location NVARCHAR(100) NOT NULL 
);
GO

-- 4. Creazione della tabella 'Product' (Prodotto)
CREATE TABLE Product (
    -- Corrisponde a: public int Id { get; set; }
    Id INT PRIMARY KEY IDENTITY(1,1),
    
    -- Corrisponde a: public string Name { get; set; }
    Name NVARCHAR(255) NOT NULL,
    
    -- Corrisponde a: [Column(TypeName = "decimal(10,2)")] public decimal Price { get; set; }
    Price DECIMAL(10,2) NOT NULL,
    
    -- Corrisponde a: public int WarehouseId { get; set; } (Foreign Key)
    WarehouseId INT NOT NULL,

    -- Definizione della Chiave Esterna (Foreign Key)
    CONSTRAINT FK_Product_Warehouse_WarehouseId 
        FOREIGN KEY (WarehouseId) 
        REFERENCES Warehouse (Id) 
        ON DELETE CASCADE -- La cancellazione del magazzino cancella i prodotti
);
GO