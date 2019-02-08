CREATE DATABASE TableRelations
GO

USE TableRelations
GO

--1
CREATE TABLE Passports
(
	PassportID INT PRIMARY KEY IDENTITY(101,1) NOT NULL,
	PassportNumber NVARCHAR(50)
)

CREATE TABLE Persons
(
	PersonID INT PRIMARY KEY IDENTITY NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	Salary DECIMAL(7,2) NOT NULL,
	PassportID INT UNIQUE, CONSTRAINT FK_Persons_Passports FOREIGN KEY (PassportID) REFERENCES Passports(PassportID)
)

INSERT INTO Passports VALUES
('N34FG21B'), 
('K65LO4R7'), 
('ZE657QP2')

INSERT INTO Persons VALUES
('Roberto', 43300.00, 102),
('Tom', 56100.00, 103),
('Yana', 60200.00, 101)

SELECT * FROM Passports
SELECT * FROM Persons

--2
CREATE TABLE Manufacturers
(
	ManufacturerID INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	EstablishedOn DATE
)

CREATE TABLE Models
(
	ModelID INT PRIMARY KEY IDENTITY(101,1) NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	ManufacturerID INT, CONSTRAINT FK_Models_Manifacturers FOREIGN KEY(ManufacturerID) REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO Manufacturers VALUES
('BMW', '1916-03-07'),
('Tesla', '2003-01-01'),
('Lada', '1966-05-01')

INSERT INTO Models VALUES
('X1', 1),
('i6', 1),
('Model S', 2),
('Model X', 2),
('Model 3', 2),
('Nova', 3)

SELECT * FROM Manufacturers
SELECT * FROM Models

--3
CREATE TABLE Students 
(
	StudentID INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(77) NOT NULL
)

CREATE TABLE Exams 
(
	ExamID INT PRIMARY KEY IDENTITY(101, 1) NOT NULL,
	[Name] VARCHAR(77) NOT NULL
)

CREATE TABLE StudentsExams
(
	StudentID INT CONSTRAINT FK_StudentsExams_Students FOREIGN KEY REFERENCES Students(StudentID),
	ExamID INT FOREIGN KEY REFERENCES Exams(ExamID)  CONSTRAINT PK_StudentsExams_Exams PRIMARY KEY(StudentID, ExamID)
)

INSERT INTO Students VALUES
('Mila'), ('Toni'), ('Ron')

INSERT INTO Exams VALUES
('SpringMVC'), ('Neo4j'), ('Oracle 11g')

INSERT INTO StudentsExams VALUES
(1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103)

SELECT * FROM Students
SELECT * FROM Exams
SELECT * FROM StudentsExams

--4
CREATE TABLE Teachers
(
	TeacherID INT PRIMARY KEY IDENTITY(101, 1) NOT NULL,
	[Name] VARCHAR(30) NOT NULL,
	ManagerID INT FOREIGN KEY REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers VALUES
('John', NULL),
('Maya', 106),
('Silvia', 106),
('Ted', 105),
('Mark', 101),
('Greta', 101)

SELECT * FROM Teachers

--5
CREATE DATABASE OnlineStore
GO

USE OnlineStore
GO

CREATE TABLE ItemTypes
(
	ItemTypeID INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Items
(
	ItemID INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	ItemTypeID INT FOREIGN KEY REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE Cities
(
	CityID INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Customers
(
	CustomerID INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	Birthdat DATE,
	CityID INT FOREIGN KEY REFERENCES Cities(CityID)
)

CREATE TABLE Orders
(
	OrderID INT PRIMARY KEY IDENTITY NOT NULL,
	CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID)
)

CREATE TABLE OrderItems
(
	OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
	ItemID INT FOREIGN KEY REFERENCES Items(ItemID)
	CONSTRAINT PK_OrdersItemsID PRIMARY KEY (OrderID, ItemID)
)

--6
CREATE TABLE Majors
(
	MajorID INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(77)
)

CREATE TABLE Subjects
(
	SubjectID INT PRIMARY KEY IDENTITY NOT NULL,
	SubjectName VARCHAR(77)
)

CREATE TABLE Students
(
	StudentID INT PRIMARY KEY IDENTITY NOT NULL,
	StudentNumber INT,
	StudentName VARCHAR(77),
	MajorID INT FOREIGN KEY REFERENCES Majors(MajorID)
)

CREATE TABLE Agenda
(
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
	SubjectID  INT FOREIGN KEY REFERENCES Subjects(SubjectID),
	CONSTRAINT PK_StudentSubjectID PRIMARY KEY(StudentID, SubjectID)
)

CREATE TABLE Payments
(
	PaymentID INT PRIMARY KEY IDENTITY NOT NULL,
	PaymentDate DATE,
	PaymentAmount DECIMAL (8, 2),
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
)

--7
/* Double click on the SoftUni database, 
   Right click on Database Diagrams, 
   New Database Diagram,
   Add all the tables,
   Close and see the result
*/

--8
/* Double click on the Geography database, 
   Right click on Database Diagrams, 
   New Database Diagram,
   Add all the tables,
   Close and see the result
*/

--9
SELECT * FROM Peaks

SELECT * FROM Mountains

SELECT Mountains.MountainRange AS MountainRange, Peaks.PeakName AS PeakName, Peaks.Elevation AS Elevation FROM Peaks
JOIN Mountains ON Mountains.Id = Peaks.MountainId
WHERE MountainId = 17
ORDER BY Elevation DESC