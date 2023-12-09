----------------------------------------------------------------------------------------------------
----- SCRIPT TO CREATE AND FILL THE IMSDatabase WITH REQUIRED TABLES AND SAMPLE DATA
----------------------------------------------------------------------------------------------------

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'IMSDatabase')
BEGIN
    CREATE DATABASE IMSDatabase;
END;
GO

USE IMSDatabase;
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Employees')
BEGIN
-- Create Employees table
	CREATE TABLE Employees (
		EmployeeId INT IDENTITY(1,1) PRIMARY KEY,
		FirstName VARCHAR(50) NOT NULL,
		MiddleName VARCHAR(50),
		LastName VARCHAR(50) NOT NULL,
		Position VARCHAR(50) NOT NULL,
		Email VARCHAR(50) NOT NULL,
		Phone VARCHAR(15),
		Username VARCHAR(50) NOT NULL,
		Password VARCHAR(50) NOT NULL
	);

	-- Insert sample data into Employees Table
	INSERT INTO Employees VALUES
	('Emily', NULL, 'Anderson', 'Deli', 'emily.anderson@email.com', NULL, 'eanderson', HASHBYTES('SHA2_256', 'password123')),
	('Alexander', 'James', 'Mitchell', 'Cashier', 'alex.mitchell@email.com', '555-5678', 'amitchell', HASHBYTES('SHA2_256', 'securepass')),
	('Olivia', 'Marie', 'Patel', 'Stock Clerk', 'olivia.patel@email.com', '555-9876', 'opatel', HASHBYTES('SHA2_256', 'pass123')),
	('Benjamin', 'Thomas', 'Reynolds', 'Manager', 'ben.reynolds@email.com', '555-4321', 'breynolds', HASHBYTES('SHA2_256', 'qwerty')),
	('Sophia', NULL, 'Carter', 'Administrator', 'sophia.carter@email.com', '555-8765', 'scarter', HASHBYTES('SHA2_256', 'letmein'));
END;

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Products')
BEGIN
	-- Create Products (Groceries) table
	CREATE TABLE Products (
		ProductId INT IDENTITY(1,1) PRIMARY KEY,
		ProductName VARCHAR(100) NOT NULL,
		ProductDescription TEXT,
		ProductCategory VARCHAR(50) NOT NULL,
		Quantity INT NOT NULL,
		Unit VARCHAR(20) NOT NULL,
		UnitPrice DECIMAL(10, 2) NOT NULL,
		State VARCHAR(50) NOT NULL,
		MaxStock INT NOT NULL
	);

	-- Insert sample data into Products Table
	INSERT INTO Products VALUES
	('Apples', 'Fresh and crisp apples', 'Fruits', 100, 'Pound', 1.99, 'In Stock', 200),
	('Milk', 'Whole milk, 1 gallon', 'Dairy', 50, 'Gallon', 2.49, 'In Stock', 100),
	('Bread', NULL, 'Bakery', 75, 'Loaf', 2.99, 'In Stock', 150),
	('Eggs', 'Large brown eggs, dozen', 'Dairy', 40, 'Dozen', 3.99, 'In Stock', 80),
	('Bananas', 'Ripe and yellow bananas', 'Fruits', 80, 'Pound', 1.29, 'In Stock', 150),
	('Chicken Breast', 'Boneless, skinless, 1lb', 'Meat', 30, 'Pound', 4.99, 'In Stock', 60),
	('Pasta', 'Whole wheat spaghetti, 1lb', 'Pasta', 25, 'Box', 1.79, 'In Stock', 50),
	('Tomatoes', 'Fresh tomatoes, 1lb', 'Vegetables', 60, 'Pound', 2.49, 'In Stock', 100);
END;

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Inventory')
BEGIN
	-- Create Inventory table with foreign keys
	CREATE TABLE Inventory (
		InventoryLogId INT IDENTITY(1,1) PRIMARY KEY,
		EmployeeId INT,
		ProductId INT,
		QuantityChange INT NOT NULL,
		InventoryLogDate DATE NOT NULL,
		ExpirationDate DATE NOT NULL,
		InventoryAction VARCHAR(50) NOT NULL,
		Notes TEXT,
		FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId),
		FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
	);

	-- Insert sample data into Inventory Table
	INSERT INTO Inventory VALUES
	(1, 5, -20, '2023-12-09', '2024-01-01', 'Sale', 'Sold 20 pounds of bananas'),
	(2, 1, -5, '2023-12-10', '2024-01-15', 'Sale', 'Sold 5 pounds of apples'),
	(3, 4, 10, '2023-12-11', '2024-02-01', 'Purchase', 'Received 10 dozens of eggs'),
	(4, 6, 15, '2023-12-12', '2024-03-01', 'Purchase', 'Received 15 pounds of chicken breast'),
	(5, 7, -10, '2023-12-13', '2024-01-01', 'Sale', 'Sold 10 boxes of pasta'),
	(1, 3, 25, '2023-12-14', '2024-02-01', 'Purchase', 'Received 25 loaves of bread'),
	(3, 2, -8, '2023-12-15', '2024-01-15', 'Sale', 'Sold 8 gallons of milk'),
	(2, 5, -15, '2023-12-16', '2024-02-01', 'Sale', 'Sold 15 pounds of bananas'),
	(1, 1, 30, '2023-12-17', '2024-01-01', 'Purchase', 'Received 30 pounds of apples'),
	(4, 8, 5, '2023-12-18', '2024-01-15', 'Purchase', 'Received 5 pounds of tomatoes'),
	(5, 3, -12, '2023-12-19', '2024-01-01', 'Sale', 'Sold 12 boxes of pasta'),
	(3, 7, 20, '2023-12-20', '2024-02-01', 'Purchase', 'Received 20 boxes of pasta'),
	(2, 4, -7, '2023-12-21', '2024-01-15', 'Sale', 'Sold 7 dozens of eggs'),
	(1, 5, -20, '2023-12-22', '2024-01-01', 'Sale', 'Sold 20 pounds of bananas'),
	(2, 1, -5, '2023-12-23', '2024-01-15', 'Sale', 'Sold 5 pounds of apples'),
	(3, 4, 10, '2023-12-24', '2024-02-01', 'Purchase', 'Received 10 dozens of eggs'),
	(4, 6, 15, '2023-12-25', '2024-03-01', 'Purchase', 'Received 15 pounds of chicken breast'),
	(5, 7, -10, '2023-12-26', '2024-01-01', 'Sale', 'Sold 10 boxes of pasta'),
	(1, 3, 25, '2023-12-27', '2024-02-01', 'Purchase', 'Received 25 loaves of bread'),
	(3, 2, -8, '2023-12-28', '2024-01-15', 'Sale', 'Sold 8 gallons of milk'),
	(2, 5, -15, '2023-12-29', '2024-02-01', 'Sale', 'Sold 15 pounds of bananas');
END;
GO

----------------------------------------------------------------------------------------------------
----- OTHER SCRIPTS
----------------------------------------------------------------------------------------------------

--SELECT * FROM IMSDatabase.dbo.Employees
--SELECT * FROM IMSDatabase.dbo.Inventory
--SELECT * FROM IMSDatabase.dbo.Products

--DROP TABLE IMSDatabase.dbo.Inventory
--DROP TABLE IMSDatabase.dbo.Products
--DROP TABLE IMSDatabase.dbo.Employees

--DROP DATABASE IF EXISTS IMSDatabase;
