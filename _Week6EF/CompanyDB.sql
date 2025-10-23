-- Create a new database called CompanyDB
CREATE DATABASE CompanyDB;
GO

-- Use the new database
USE CompanyDB;
GO

-- Create the Departments table with sample data
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName NVARCHAR(50) NOT NULL
);
GO

-- Insert dummy data into the Departments table
INSERT INTO Departments (DepartmentName)
VALUES 
('IT'),            -- DepartmentID 1 
('HR'),            -- DepartmentID 2
('Finance');       -- DepartmentID 3
GO

-- Create a table for storing employee details
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1), -- Primary key auto-increment field
    FirstName NVARCHAR(50) NOT NULL,          -- Employee first name
    LastName NVARCHAR(50) NOT NULL,           -- Employee last name
    Email NVARCHAR(100) NOT NULL,             -- Employee email address
    HireDate DATE NOT NULL,                   -- Date when the employee was hired
    DepartmentID INT,                         -- Employee Department
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);
GO

-- Insert dummy data into the Employees table
INSERT INTO Employees (FirstName, LastName, Email, HireDate, DepartmentID)
VALUES 
('John', 'Doe', 'john.doe@example.com', '2020-01-15', 1),
('Jane', 'Smith', 'jane.smith@example.com', '2019-03-22', 2),
('Michael', 'Johnson', 'michael.johnson@example.com', '2021-07-01', 3);
GO