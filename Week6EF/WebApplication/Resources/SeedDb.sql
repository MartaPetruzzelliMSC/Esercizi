USE [DatabaseFirstDb];
GO

-- 1. Inserimento dei Magazzini (Warehouse)
-- Magazzino 1: Milano
INSERT INTO Warehouse (Location)
VALUES ('Milano - Deposito Centrale');

-- Magazzino 2: Roma
INSERT INTO Warehouse (Location)
VALUES ('Roma - Logistica Sud');
GO

-- 2. Inserimento dei Prodotti (Product)
-- Si assumono i seguenti ID Magazzino:
-- Milano (ID = 1)
-- Roma (ID = 2)

-- Prodotti per il Magazzino di Milano (ID 1)
INSERT INTO Product (Name, Price, WarehouseId)
VALUES 
    ('Laptop Modello X', 1250.99, 1),
    ('Monitor 27 pollici', 350.50, 1),
    ('Tastiera Ergonomica', 75.00, 1);

-- Prodotti per il Magazzino di Roma (ID 2)
INSERT INTO Product (Name, Price, WarehouseId)
VALUES 
    ('Smartphone Modello Z', 899.90, 2),
    ('Caricabatterie Ultra', 25.49, 2);
GO