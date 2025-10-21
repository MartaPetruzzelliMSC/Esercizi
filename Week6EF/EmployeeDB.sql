CREATE DATABASE EmployeeDB;
GO
USE EmployeeDB;
GO
CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email VARCHAR(50),
    Position NVARCHAR(50),
    Salary DECIMAL(18, 2)
);
INSERT INTO Employee (FirstName, LastName, Email, Position, Salary)
VALUES 
('Anurag', 'Mohanty', 'Anurag@Example.com', 'Software Developer', 60000),
('Pranaya', 'Rout', 'Pranaya@Example.com', 'Project Manager', 65000),
('Hina', 'Sharma', 'Hina@Example.com', 'Database Administrator', 59000);