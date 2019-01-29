--1. Create Database
CREATE DATABASE Minions

--2.Create Tables
CREATE TABLE Minions(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	Age INT NOT NULL
)

CREATE TABLE Towns(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
)

--3.Alter Minions Table
ALTER TABLE Minions
ADD TownId INT FOREIGN KEY REFERENCES Towns(Id)

--4. Insert Records in Both Tables
INSERT INTO Towns(Id, [Name]) VALUES
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')

SELECT * FROM Towns

INSERT INTO Minions(Id, [Name], Age, TownId) VALUES
(1, 'Kevin', '22', 1),
(2, 'Bob', '15', 3),
(3, 'Steward', NULL , 2)

SELECT * FROM Minions

--5. Truncate Table Minions
TRUNCATE TABLE Minions

--6. Drop All Tables
DROP TABLE Minions
DROP TABLE Towns

--7. Create Table People
CREATE TABLE People(
	Id INT PRIMARY KEY IDENTITY NOT NULL CHECK (Id < 2147483647),
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY CHECK (DATALENGTH(Picture)<900*1024),
	Height DECIMAL(10,2),
	[Weight] DECIMAL(10,2),
	Gender CHAR(1) NOT NULL CHECK (Gender = 'm' OR Gender = 'f'),
	Birthdate DATE NOT NULL,
	Biography NVARCHAR(MAX) 
)

INSERT INTO People (Name, Picture, Height, Weight, Gender, Birthdate, Biography) VALUES
('Kubrat', NULL, 1.60, 15, 'm', '01-01-0600', 'Old Great Bulgaria'),
('Asparuh', NULL, 1.70, 25, 'm', '01-01-0640', 'Establish Bulgaria'),
('Tervel', NULL, 1.75, 35, 'm', '01-01-0700', 'Destroy arabians!'),
('Omurtag', NULL, 1.80, 45, 'm', '01-01-0800', 'Great Builder!'),
('Kaloqn', NULL, 1.95, 55, 'm', '01-01-0900', 'Destroy Lanin knights')

--8. Create Table Users
CREATE TABLE Users(
	Id INT PRIMARY KEY IDENTITY NOT NULL CHECK (Id < 2147483647),
	Username VARCHAR(30) NOT NULL UNIQUE,
	Password VARCHAR(26) NOT NULL, 
	ProfilePicture VARBINARY CHECK (DATALENGTH(ProfilePicture)<900*1024),
	LastLoginTime DATE,
	IsDeleted BIT
)

INSERT INTO Users (Username, Password, ProfilePicture, LastLoginTime, IsDeleted) VALUES
('Ivan', 'aswwwerwerwdfghjk', NULL, CONVERT(datetime,'11-01-2018',103), 'true'),
('Stoqn', 'qwerrewrerwretyu', NULL, CONVERT(datetime,'11-02-2018',103), 'true'),
('Petar', 'zxcvbnmrewrerwer', NULL, CONVERT(datetime,'11-03-2018',103), 'true'),
('Georgi', 'qazwsxedcrfveee', NULL, CONVERT(datetime,'11-04-2018',103), 'true'),
('Dimitar', 'tgbyhnujmiklop', NULL, CONVERT(datetime,'11-05-2018',103), 'true')

--9. Change Primary Key
ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC079C9110A1

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY(Id, UserName)

--10. Add Check Constraint
ALTER TABLE Users
ADD CONSTRAINT PasswordMinLength
CHECK (LEN(Password) > 5)

INSERT INTO Users (Username, Password, ProfilePicture, LastLoginTime, IsDeleted) VALUES
('Pavel', '1234', NULL, CONVERT(datetime,'11-01-2018',103), 'true') -- Lenght Exception!

--11. Set Default Value of a Field
ALTER TABLE Users
ADD DEFAULT GETDATE() FOR LastLoginTime

--12. Set Unique Field
ALTER TABLE Users
DROP CONSTRAINT PK_Users

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY (Id)

ALTER TABLE Users
ADD CONSTRAINT uc_Username UNIQUE (Username)

ALTER TABLE Users
ADD CONSTRAINT uc_UsernameLength
CHECK (LEN(Username) >= 3)

INSERT INTO Users (Username, Password, ProfilePicture, LastLoginTime, IsDeleted) VALUES
('Pa', '1234567', NULL, CONVERT(datetime,'11-01-2018',103), 'true') -- Lenght Exception!

--13. Movies Database
CREATE DATABASE Movies 

USE Movies

CREATE TABLE Directors(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	DirectorName NVARCHAR(100) NOT NULL,
	Notes NVARCHAR(MAX) NOT NULL
)

CREATE TABLE Genres(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	GenreName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX) NOT NULL
)

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	CategoryName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX) NOT NULL
)

CREATE TABLE Movies(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	Title NVARCHAR(50) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors(Id), 
	CopyrightYear DATE,
	[Length] BIGINT,
	GenreId INT FOREIGN KEY REFERENCES Genres(Id),
	Rating INT,
	Notes NVARCHAR(MAX)
)

INSERT INTO Directors (DirectorName, Notes) VALUES
('First Director', 'Nice man'),
('Second Director', 'Cool man'),
('Third Director', 'Good man'),
('Fourth Director', 'Bad man'),
('Fifth Director', 'Evil man')

INSERT INTO Genres(GenreName, Notes) VALUES
('comedy', 'laughing'),
('thriller', 'crying'),
('drama', 'idk'),
('action', 'presure'),
('documentary', 'thinking')

INSERT INTO Categories(CategoryName, Notes) VALUES
('smart', 'thinking'),
('stupid', 'staying'),
('nice', 'smiling'),
('good', 'happy'),
('bad', 'angry')

INSERT INTO Movies (Title, DirectorId, CopyrightYear, [Length], GenreId, Rating, Notes) VALUES
('Prison Break', 1, '1990', '103', 1, 6, 'Get out'),
('Interstellar', 2, '1992', '103', 2, 7, 'Lets go'),
('Matrix', 3, '1994', '103', 3, 8, 'Move on'),
('Predestination', 4, '1996', '103', 4, 9, 'Get low'),
('Inception', 5, '1998', '103', 5, 10, 'Get up')

--14. Car Rental Database
CREATE DATABASE CarRental

USE CarRental

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	CategoryName NVARCHAR(50),
	DailyRate DECIMAL(5, 2) NOT NULL,
	WeeklyRate DECIMAL(5, 2) NOT NULL,
	MonthlyRate DECIMAL(5, 2) NOT NULL,
	WeekendRate DECIMAL(5, 2) NOT NULL
)

INSERT INTO Categories (CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) VALUES
('Cabrio', 6.44, 7.55, 5.54, 2.55),
('Hatch-back', 5.34, 9.65, 4.55, 8.52),
('Sedan', 7.87, 1.55, 5.56, 5.55)

CREATE TABLE Cars (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	PlateNumber VARCHAR(8),
	Manufacturer VARCHAR(30),
	Model VARCHAR(30),
	CarYear DATE,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Doors REAL,
	Picture VARBINARY(MAX),
	Condition NVARCHAR(100),
	Available BIT
)

INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Condition, Available) VALUES
('C 1234 C', 'Audi', 'a4', '11-11-1990', 1, 2, 'USED', 1),
('C 1212 C', 'Audi', 'a6', '11-11-1999', 2, 4, 'USED', 1),
('C 3434 C', 'Audi', '80', '11-11-1980', 3, 4, 'USED', 1)

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(30),
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees (FirstName, LastName) VALUES
('Ivan', 'Ivanov'),
('Petar', 'Petrov'),
('Dimitar', 'Dimitar')

CREATE TABLE Customers (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	DriverLicenceNumber NVARCHAR(15) NOT NULL,
	FullName NVARCHAR(100) NOT NULL,
	Address NVARCHAR(500),
	City NVARCHAR(50),
	ZIPCode NVARCHAR(10),
	Notes NVARCHAR(200)
)

INSERT INTO Customers (DriverLicenceNumber, FullName, Address, City, ZIPCode, Notes) VALUES
('B2', 'Ivan Ivanov','Mladost', 'Sofia', '1111', 'Gotin'),
('B2', 'Petar Petrov','Mladost', 'Sofia', '1112', 'Pechen'),
('B2', 'Dimitar Dimitrov','Mladost', 'Sofia', '1113', 'Smotan')

CREATE TABLE RentalOrders (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
	CarId INT,
	TankLevel INT,
	KilometrageStart INT,
	KilometrageEnd INT,
	TotalKilometrage INT,
	StartDate DATE,
	EndDate DATE,
	TotalDays AS DATEDIFF(DAY, StartDate, EndDate),
	RateApplied INT,
	TaxRate DECIMAL(5, 2),
	OrderStatus NVARCHAR(50),
	Notes NVARCHAR(MAX)
)

INSERT INTO RentalOrders (EmployeeId, CustomerId, StartDate, EndDate) VALUES
(3, 2, '11-11-1990', '11-11-1990'),
(1, 1, '11-11-1990', '11-11-1990'),
(2, 3, '11-11-1990', '11-11-1990')

--15. Hotel Database
CREATE DATABASE Hotel

USE Hotel

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(100),
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees (FirstName, LastName) VALUES
('Ivan', 'Ivanov'),
('Georgi', 'Georgiev'),
('Martin', 'Martinov')

CREATE TABLE Customers (
	AccountNumber INT UNIQUE IDENTITY NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	PhoneNumber INT,
	EmergencyName NVARCHAR(100),
	EmergencyNumber INT,
	Notes NVARCHAR(MAX)
)

INSERT INTO Customers (FirstName, LastName) VALUES
('Jordan', 'Jordanov'),
('Dimitar', 'Dimitrov'),
('Petar', 'Petrov')

CREATE TABLE RoomStatus (
	RoomStatus NVARCHAR(50) PRIMARY KEY NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO RoomStatus (RoomStatus) VALUES
('Free'),
('Cleaning'),
('Busy')

CREATE TABLE RoomTypes (
	RoomType NVARCHAR(50) PRIMARY KEY NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO RoomTypes (RoomType) VALUES
('1 people'),
('2 people'),
('4 people')

CREATE TABLE BedTypes (
	BedType NVARCHAR(50) PRIMARY KEY NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO BedTypes (BedType) VALUES
('One Person'),
('Two Person'),
('Four Person')

CREATE TABLE Rooms (
	RoomNumber INT PRIMARY KEY IDENTITY NOT NULL,
	RoomType NVARCHAR(50) FOREIGN KEY REFERENCES RoomTypes(RoomType),
	BedType NVARCHAR(50) FOREIGN KEY REFERENCES BedTypes(BedType),
	Rate DECIMAL(6,2),
	RoomStatus NVARCHAR(50),
	Notes NVARCHAR(MAX)
)

INSERT INTO Rooms (Rate) VALUES
(5.00),
(7.50),
(10.00)

CREATE TABLE Payments (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	EmployeeId INT,
	PaymentDate DATE,
	AccountNumber INT,
	FirstDateOccipied DATE,
	LastDateOccupied DATE,
	TotalDays AS DATEDIFF(DAY, FirstDateOccipied, LastDateOccupied),
	AmountCharged DECIMAL(10, 2),
	TaxRate DECIMAL(6, 2),
	TaxAmount DECIMAL(6, 2),
	PaymentTotal DECIMAL(12, 2),
	Notes NVARCHAR(MAX)
)

INSERT INTO Payments (EmployeeId, PaymentDate, AmountCharged) VALUES
(1, GETDATE(), 100.50),
(2, GETDATE(), 200.50),
(3, GETDATE(), 300.50)

CREATE TABLE Occupancies (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	EmployeeId INT,
	DateOccipied DATE,
	AccountNumber INT,
	RoomNumber INT,
	RateApplied DECIMAL(6, 2),
	PhoneCharge DECIMAL(10, 2),
	Notes NVARCHAR(MAX)
)

INSERT INTO Occupancies (EmployeeId, RateApplied, Notes) VALUES
(1, 8.00, 'okay'),
(2, 9.00, 'perfect'),
(3, 5.00, 'not god')

--16. Create SoftUni Database
CREATE DATABASE SoftUni

USE SoftUni

CREATE TABLE Towns (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Addresses (
	Id INT PRIMARY KEY IDENTITY,
	AddressText NVARCHAR(100) NOT NULL,
	TownId INT CONSTRAINT FK_Addresses_Town FOREIGN KEY REFERENCES Towns(Id)
)

CREATE TABLE Departments (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50)
)

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	MiddleName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	JobTitle NVARCHAR(35) NOT NULL,
	DepartmentId INT CONSTRAINT FK_Employees_Department FOREIGN KEY REFERENCES Departments(Id) NOT NULL,
	HireDate DATE NOT NULL,
	Salary DECIMAL(10,2) NOT NULL,
	AddressId INT CONSTRAINT FK_Employees_Addresses FOREIGN KEY REFERENCES Addresses(Id)
)

--17. Backup Database
BACKUP DATABASE [SoftUni] 
	TO  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER14\MSSQL\Backup\SoftUni.bak' 
	WITH NOFORMAT, NOINIT,  
	NAME = N'SoftUni-Full Database Backup', 
	SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO

--18. Basic Insert
INSERT INTO Towns ([Name]) VALUES
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas')

INSERT INTO Departments (Name) VALUES
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance')

INSERT INTO Employees (FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary) VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, CONVERT(datetime,'2013/01/02', 103), 3500.00),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, CONVERT(datetime,'2004/02/03', 103), 4000.00),
('Maria', 'Petrova', 'Ivanova', 'Intern', 5, CONVERT(datetime,'2016/28/08', 103), 525.25),
('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, CONVERT(datetime,'2007/09/12', 103), 3000.00),
('Peter', 'Pan', 'Pan', 'Intern', 3, CONVERT(datetime,'2016/28/08', 103), 599.88)

--19. Basic Select All Fields
SELECT * FROM Towns

SELECT * FROM Departments

SELECT * FROM Employees

--20. Basic Select All Fields and Order Them
SELECT * FROM Towns ORDER BY Name

SELECT * FROM Departments ORDER BY Name

SELECT * FROM Employees ORDER BY Salary DESC

--21. Basic Select Some Fields
SELECT Name FROM Towns ORDER BY Name

SELECT Name FROM Departments ORDER BY Name

SELECT FirstName, LastName, JobTitle, Salary FROM Employees ORDER BY Salary DESC

--22. Increase Employees Salary
UPDATE Employees
SET Salary *= 1.1  

SELECT Salary FROM Employees

--23. Decrease Tax Rate
USE Hotel

UPDATE Payments
SET TaxRate -= TaxRate * 0.03

SELECT TaxRate FROM Payments

--24. Delete All Records
DELETE FROM Occupancies
SELECT * FROM Occupancies