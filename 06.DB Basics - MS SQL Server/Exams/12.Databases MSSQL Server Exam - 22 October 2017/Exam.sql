CREATE DATABASE ReportService
USE ReportService
GO
--1
CREATE TABLE Users(
	Id INT PRIMARY KEY IDENTITY,
	Username NVARCHAR(30) UNIQUE NOT NULL,
	[Password] NVARCHAR(59) NOT NULL,
	[Name] NVARCHAR(30),
	Gender CHAR(1) CHECK (Gender IN ('M', 'F')),
	BirthDate DATETIME,
	Age NVARCHAR(MAX),
	Email NVARCHAR(50) NOT NULL
)

CREATE TABLE Departments(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Employees(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(25),
	LastName NVARCHAR(25),
	Gender CHAR(1) CHECK (Gender IN ('M', 'F')),
	BirthDate DATETIME,
	Age NVARCHAR(MAX),
	DepartmentId INT FOREIGN KEY (DepartmentId) REFERENCES Departments(Id) NOT NULL
)

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL,
	DepartmentId INT FOREIGN KEY (DepartmentId) REFERENCES Departments(Id)
)

CREATE TABLE Status(
	Id INT PRIMARY KEY IDENTITY,
	Label  NVARCHAR(30) NOT NULL,
)

CREATE TABLE Reports(
	Id INT PRIMARY KEY IDENTITY,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
	StatusId INT FOREIGN KEY REFERENCES Status(Id) NOT NULL,
	OpenDate DATETIME NOT NULL,
	CloseDate DATETIME,
	[Description] NVARCHAR(MAX) NOT NULL,
	UserId INT FOREIGN KEY REFERENCES Users(Id) NOT NULL,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id)
)

--2
INSERT INTO Employees(FirstName, LastName, Gender, BirthDate, DepartmentId)
VALUES
('Marlo', 'O’Malley', 'M', '9/21/1958', 1),
('Niki',	'Stanaghan',	'F',	'11/26/1969', 4),
('Ayrton',	'Senna',	'M',	'03/21/1960', 	9),
('Ronnie',	'Peterson',	'M',	'02/14/1944',	9),
('Giovanna',	'Amati',	'F',	'07/20/1959',	5)

INSERT INTO Reports(CategoryId, StatusId, OpenDate, CloseDate, [Description], UserId, EmployeeId)
VALUES
(1,	1,	'04/13/2017',	NULL,	'Stuck Road on Str.133',	6,	2),
(6,	3,	'09/05/2015',	'12/06/2015',	'Charity trail running',	3,	5),
(14,	2,	'09/07/2015',NULL,		'Falling bricks on Str.58',	5,	2),
(4,	3,	'07/03/2017',	'07/06/2017',	'Cut off streetlight on Str.11',	1,	1)

--3
SELECT * FROM Status
SELECT * FROM Reports

UPDATE Reports
	SET StatusId = 2
	WHERE StatusId = 1 AND CategoryId = 4

--4
DELETE FROM Reports
	WHERE StatusId = 4

--5
SELECT Username, Age FROM Users
	ORDER BY Age, Username DESC

--6
SELECT [Description], OpenDate FROM Reports
	WHERE EmployeeId IS NULL
	ORDER BY OpenDate, [Description]

--7
SELECT e.FirstName, e.LastName, r.Description, FORMAT(r.OpenDate, 'yyyy-MM-dd') AS [OpenDate] FROM Employees AS e
	INNER JOIN Reports AS r
	ON r.EmployeeId = e.Id
	WHERE EmployeeId IS NOT NULL
	ORDER BY e.Id, r.OpenDate, r.Id

--8
SELECT c.Name AS [CategoryName], COUNT(r.Id) AS [ReportsNumber] FROM Categories AS c
	INNER JOIN Reports AS r
	ON r.CategoryId = c.Id
	GROUP BY c.Name
	ORDER BY ReportsNumber DESC, CategoryName

--9
SELECT c.Name AS [CategoryName], COUNT(e.Id) AS [Employees Number] FROM Categories AS c
INNER JOIN Departments AS d
ON d.Id = c.DepartmentId
INNER JOIN Employees AS e
ON e.DepartmentId = d.Id
GROUP BY c.Name
ORDER BY c.Name

--10

SELECT DISTINCT e.FirstName + ' ' + e.LastName AS [Name], COUNT(r.UserId)  AS [Users Number] FROM Reports AS r
RIGHT JOIN Employees AS e
ON e.Id = r.EmployeeId
GROUP BY e.FirstName + ' ' + e.LastName
ORDER BY [Users Number] DESC, [Name]

--11
SELECT r.OpenDate, r.Description, u.Email AS [Reporter Mail] FROM Reports AS r
JOIN Categories AS c
ON c.Id = r.CategoryId
JOIN Users AS u
ON r.UserId = u.Id
WHERE r.CloseDate IS NULL AND LEN(r.Description) > 20 AND Description LIKE '%str%' AND c.DepartmentId IN(1,4,5)
ORDER BY r.OpenDate, u.Email, r.Id

--12
SELECT DISTINCT c.[Name] AS [Category Name] FROM Reports AS r
JOIN Categories AS c
ON c.Id = r.CategoryId
JOIN Users AS u
ON u.Id = r.UserId
WHERE DAY(r.OpenDate) = DAY(u.BirthDate) AND MONTH(r.OpenDate) = MONTH(u.BirthDate)
ORDER BY [Category Name]

--13
SELECT DISTINCT u.Username FROM Reports AS r
JOIN Categories AS c
ON c.Id = r.CategoryId
JOIN Users AS u
ON u.Id = r.UserId
WHERE LEFT(u.Username, 1) LIKE '[0-9]' AND CONVERT(VARCHAR(10),c.Id) = LEFT(u.Username,1)
OR RIGHT(u.Username, 1) LIKE '[0-9]' AND CONVERT(VARCHAR(10),c.Id) = (RIGHT(u.Username,1)) 
ORDER BY u.Username

--14
SELECT E.Firstname+' '+E.Lastname AS FullName, 
	   ISNULL(CONVERT(varchar, CC.ReportSum), '0') + '/' +        
       ISNULL(CONVERT(varchar, OC.ReportSum), '0') AS [Stats]
FROM Employees AS E
JOIN (SELECT EmployeeId,  COUNT(1) AS ReportSum
	  FROM Reports R
	  WHERE  YEAR(OpenDate) = 2016
	  GROUP BY EmployeeId) AS OC ON OC.Employeeid = E.Id
LEFT JOIN (SELECT EmployeeId,  COUNT(1) AS ReportSum
	       FROM Reports R
	       WHERE  YEAR(CloseDate) = 2016
	       GROUP BY EmployeeId) AS CC ON CC.Employeeid = E.Id
ORDER BY FullName

--15
SELECT d.Name, ISNULL(CONVERT(VARCHAR(10),AVG(DATEDIFF(DAY, r.OpenDate, r.CloseDate))), 'no info') AS [Average Duration] FROM Departments AS d
JOIN Categories AS c
ON c.DepartmentId = d.Id
JOIN Reports AS r
ON r.CategoryId = c.Id
GROUP BY d.Name

--16
SELECT Department,
       Category,
       Percentage
FROM
    (SELECT D.Name AS Department,
		    C.Name AS Category,
		    CAST(
			     ROUND(
				       COUNT(1) OVER(PARTITION BY C.Id) * 100.00 / COUNT(1) OVER(PARTITION BY D.Id), 0
					  ) as int
				) AS Percentage
     FROM Categories AS C
		  JOIN Reports AS R ON R.Categoryid = C.Id
		  JOIN Departments AS D ON D.Id = C.Departmentid) AS Stats
GROUP BY Deprtment,
         Category,
         Percentage;
ORDER BY Deprtment,
         Category,
         Percentage;
GO

--17
CREATE FUNCTION udf_GetReportsCount(@employeeId INT, @statusId INT)
RETURNS INT
BEGIN
	DECLARE @result INT = (SELECT COUNT(r.Id) FROM Reports AS r
	WHERE r.EmployeeId = @employeeId AND r.StatusId = @statusId)
	RETURN @result
END
GO


--20
SELECT c.Name , COUNT(r.Id) AS [Report Number],
CASE
	WHEN SUM(CASE WHEN r.StatusId = 2 THEN 1 ELSE 0 END) >
	SUM(CASE WHEN r.StatusId = 1 THEN 1 ELSE 0 END) THEN 'in progress'
	WHEN SUM(CASE WHEN r.StatusId = 2 THEN 1 ELSE 0 END) <
	SUM(CASE WHEN r.StatusId = 1 THEN 1 ELSE 0 END) THEN 'waiting'
	ELSE 'equal'
END AS MainStatus FROM Reports AS r
JOIN Categories AS c
ON r.CategoryId = c.Id
WHERE r.StatusId IN(1,2)
GROUP BY c.Name
ORDER BY c.Name, [Report Number], MainStatus

SELECT * FROM Reports
SELECT * FROM Categories
SELECT * FROM Users