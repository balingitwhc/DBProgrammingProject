--DROP TABLE IMSDatabase.dbo.Inventory
--DROP TABLE IMSDatabase.dbo.Products
--DROP TABLE IMSDatabase.dbo.Employees

SELECT * FROM IMSDatabase.dbo.Employees
SELECT * FROM IMSDatabase.dbo.Inventory
SELECT * FROM IMSDatabase.dbo.Products

-----------------------------------------------------------------------------------------

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

-- Insert sample data into Employees, Products, and Inventory tables
INSERT INTO Employees VALUES
('Emily', NULL, 'Anderson', 'Deli', 'emily.anderson@email.com', NULL, 'eanderson', HASHBYTES('SHA2_256', 'password123')),
('Alexander', 'James', 'Mitchell', 'Cashier', 'alex.mitchell@email.com', '555-5678', 'amitchell', HASHBYTES('SHA2_256', 'securepass')),
('Olivia', 'Marie', 'Patel', 'Stock Clerk', 'olivia.patel@email.com', '555-9876', 'opatel', HASHBYTES('SHA2_256', 'pass123')),
('Benjamin', 'Thomas', 'Reynolds', 'Manager', 'ben.reynolds@email.com', '555-4321', 'breynolds', HASHBYTES('SHA2_256', 'qwerty')),
('Sophia', NULL, 'Carter', 'Administrator', 'sophia.carter@email.com', '555-8765', 'scarter', HASHBYTES('SHA2_256', 'letmein'));

INSERT INTO Products VALUES
('Apples', 'Fresh and crisp apples', 'Fruits', 100, 'Pound', 1.99, 'In Stock', 200),
('Milk', 'Whole milk, 1 gallon', 'Dairy', 50, 'Gallon', 2.49, 'In Stock', 100),
('Bread', NULL, 'Bakery', 75, 'Loaf', 2.99, 'Low Stock', 150),
('Eggs', 'Large brown eggs, dozen', 'Dairy', 40, 'Dozen', 3.99, 'In Stock', 80),
('Bananas', 'Ripe and yellow bananas', 'Fruits', 80, 'Pound', 1.29, 'In Stock', 150),
('Chicken Breast', 'Boneless, skinless, 1lb', 'Meat', 30, 'Pound', 4.99, 'In Stock', 60),
('Pasta', 'Whole wheat spaghetti, 1lb', 'Pasta', 25, 'Box', 1.79, 'Out of Stock', 50),
('Tomatoes', 'Fresh tomatoes, 1lb', 'Vegetables', 60, 'Pound', 2.49, 'In Stock', 100);

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

SELECT TOP (1) EmployeeId FROM Employees ORDER BY LastName, FirstName

SELECT * FROM IMSDatabase.dbo.Employees ORDER BY LastName, FirstName

SELECT * FROM Employees WHERE EmployeeId = 4

SELECT 
(
    SELECT TOP(1) EmployeeId as FirstEmployeeId FROM Employees ORDER BY LastName,FirstName
) as FirstEmployeeId,
q.PreviousEmployeeId,
q.NextEmployeeId,
(
    SELECT TOP(1) EmployeeId as LastEmployeeId FROM Employees ORDER BY LastName Desc,FirstName Desc
) as LastEmployeeId
FROM
(
    SELECT EmployeeId, LastName, FirstName,
    LEAD(EmployeeId) OVER(ORDER BY LastName,FirstName) AS NextEmployeeId,
    LAG(EmployeeId) OVER(ORDER BY LastName,FirstName) AS PreviousEmployeeId,
    ROW_NUMBER() OVER(ORDER BY LastName, FirstName) AS 'RowNumber'
    FROM Employees
) AS q
WHERE q.EmployeeId = 4
ORDER BY q.LastName,q.FirstName


-------------------------------------------------------------------------------------------------

SELECT * FROM Products ORDER BY ProductName

SELECT * FROM Products WHERE ProductId = 1

SELECT 
(
    SELECT TOP(1) ProductId as FirstProductId FROM Products ORDER BY ProductName
) as FirstProductId,
q.PreviousProductId,
q.NextProductId,
(
    SELECT TOP(1) ProductId as LastProductId FROM Products ORDER BY ProductName Desc
) as LastProductId
FROM
(
    SELECT ProductId, ProductName,
    LEAD(ProductId) OVER(ORDER BY ProductName) AS NextProductId,
    LAG(ProductId) OVER(ORDER BY ProductName) AS PreviousProductId,
    ROW_NUMBER() OVER(ORDER BY ProductName) AS 'RowNumber'
    FROM Products
) AS q
WHERE q.ProductId = 1
ORDER BY q.ProductName






-----------------------------------------------------------------------



SELECT * FROM Inventory ORDER BY ExpirationDate, InventoryLogDate


SELECT
	InventoryLogId,QuantityChange,InventoryLogDate,ExpirationDate,InventoryAction,Notes,
	Inv.EmployeeId, CONCAT(Emp.FirstName, ' ',Emp.LastName) AS [EmployeeName],Emp.Position,
	Inv.ProductId, Prod.ProductName,Prod.ProductDescription,Prod.ProductCategory
FROM    Inventory AS Inv
JOIN    Employees AS Emp ON Inv.EmployeeID = Emp.EmployeeID
JOIN    Products AS Prod ON Inv.ProductID = Prod.ProductID
--WHERE   InventoryLogID = 1
ORDER BY ExpirationDate, InventoryLogDate


SELECT 
(
    SELECT TOP(1) InventoryLogId as FirstInventoryLogId FROM Inventory ORDER BY ExpirationDate, InventoryLogDate
) as FirstInventoryLogId,
q.PreviousInventoryLogId,
q.NextInventoryLogId,
(
    SELECT TOP(1) InventoryLogId as LastInventoryLogId FROM Inventory ORDER BY ExpirationDate Desc,InventoryLogDate Desc
) as LastInventoryLogId, (SELECT COUNT(InventoryLogId) FROM Inventory) as LogCount
FROM
(
    SELECT InventoryLogId, ExpirationDate, InventoryLogDate,
    LEAD(InventoryLogId) OVER(ORDER BY ExpirationDate, InventoryLogDate) AS NextInventoryLogId,
    LAG(InventoryLogId) OVER(ORDER BY ExpirationDate, InventoryLogDate) AS PreviousInventoryLogId,
    ROW_NUMBER() OVER(ORDER BY ExpirationDate, InventoryLogDate) AS 'RowNumber'
    FROM Inventory
) AS q
WHERE q.InventoryLogId = 1
ORDER BY q.ExpirationDate,q.InventoryLogDate

------------------------------------------------------------------------------------------------------

UPDATE Employees SET [Position] = 'Deli' WHERE EmployeeId = 1
UPDATE Employees SET [Position] = 'Cashier' WHERE EmployeeId = 2
UPDATE Employees SET [Position] = 'Stock Clerk' WHERE EmployeeId = 3
UPDATE Employees SET [Position] = 'Manager' WHERE EmployeeId = 4
UPDATE Employees SET [Position] = 'Administrator' WHERE EmployeeId = 5

SELECT * FROM Employees


SELECT
    CASE
        WHEN EXISTS (
            SELECT *
            FROM Employees
            WHERE Username = 'eanderson'
              AND [Password] = HASHBYTES('SHA2_256', 'password123')
        ) THEN 1  -- Password matches
        ELSE 0  -- Password does not match
    END AS PasswordMatch;



SELECT CONCAT(FirstName, ' ',LastName) AS [EmployeeName] ,[EmployeeId], [Position]
FROM Employees
WHERE Username = 'eanderson' AND [Password] = HASHBYTES('SHA2_256', 'password123')


SELECT EmployeeId, LastName + ', ' + FirstName as [WholeName], Position
FROM Employees
ORDER BY LastName, FirstName