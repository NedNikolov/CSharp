--1
USE SoftUni
SELECT FirstName, LastName FROM Employees
WHERE FirstName LIKE 'SA%'

--2
SELECT FirstName, LastName FROM Employees
WHERE LastName LIKE '%ei%'

--3
SELECT FirstName FROM Employees
WHERE DepartmentID IN (3, 10) AND HireDate BETWEEN '1995-01-01' AND '2005-12-31'

--4
SELECT FirstName, LastName FROM Employees
WHERE NOT JobTitle LIKE '%engineer%'

--5
SELECT Name FROM Towns
WHERE LEN(Name) IN (5,6)
ORDER BY Name

--6
SELECT * FROM Towns
WHERE LEFT([Name], 1) IN ('M', 'K', 'B', 'E')
ORDER BY [Name]

SELECT * FROM Towns
WHERE [Name] LIKE '[MKBE]%'
ORDER BY [Name]

--7
SELECT * FROM Towns
WHERE NOT LEFT([Name], 1) IN ('R', 'D', 'B')
ORDER BY [Name]

SELECT * FROM Towns
WHERE NOT [Name] LIKE '[RBD]%'
ORDER BY [Name]

SELECT * FROM Towns
WHERE [Name] LIKE '[^RBD]%'
ORDER BY [Name]
GO

--8
CREATE VIEW v_EmployeesHiredAfter2000 AS
SELECT FirstName, LastName FROM Employees
WHERE DATEPART(YEAR, HireDate) > 2000
GO

SELECT * FROM v_EmployeesHiredAfter2000

--9
SELECT FirstName, LastName FROM Employees
WHERE LEN(LastName) = 5

--10
SELECT EmployeeID, FirstName, LastName, Salary,	DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID)AS Rank
FROM Employees
WHERE Salary BETWEEN '10000' AND '50000'
ORDER BY Salary DESC, Rank

--11
SELECT * FROM (SELECT EmployeeID, FirstName, LastName, Salary, DENSE_RANK() OVER(PARTITION BY Salary ORDER BY EmployeeID) AS Rank FROM Employees AS R) Employees 
WHERE Rank = 2 AND Salary BETWEEN 10000 AND 50000 
ORDER BY Salary DESC

--12
USE Geography

SELECT CountryName, IsoCode FROM Countries
WHERE CountryName LIKE '%A%A%A%'
ORDER BY IsoCode

--13
SELECT PeakName, RiverName, 
LOWER(PeakName + SUBSTRING(RiverName, 2, LEN(RiverName) - 1)) AS [Mix] FROM Peaks, Rivers
WHERE RIGHT(PeakName, 1) = LEFT(RiverName, 1)
ORDER By [Mix]

--14
USE Diablo

SELECT TOP 50 [Name], FORMAT([Start], 'yyyy-MM-dd') AS [Start] FROM Games
WHERE DATEPART (YEAR, [Start]) IN (2011, 2012)
ORDER BY [Start], [Name]

--15
SELECT Username,
SUBSTRING(Email, CHARINDEX('@', Email, 1) + 1, LEN(Email)) AS [Email Provider]
FROM Users
ORDER BY [Email Provider], Username

--16
SELECT Username, IpAddress AS [IP Address] FROM Users
WHERE IpAddress LIKE '___.1%.%.___'
ORDER BY Username

--17
SELECT [Name] AS [Game],
CASE
	WHEN DATEPART(HOUR, Start) BETWEEN 0 AND 11 THEN 'Morning'
	WHEN DATEPART(HOUR, Start) BETWEEN 12 AND 17 THEN 'Afternoon'
	WHEN DATEPART(HOUR, Start) BETWEEN 18 AND 24 THEN 'Evening'
END AS [Part of the Day],
CASE
	WHEN Duration <= 3 THEN 'Extra Short'
	WHEN Duration BETWEEN 4 AND 6 THEN 'Short'
	WHEN Duration > 6 THEN 'Long'
	WHEN Duration IS NULL THEN 'Extra Long'
END AS [Duration]
FROM Games
ORDER BY Game, Duration, [Part of the Day]

--18
USE Orders

SELECT ProductName, OrderDate,
DATEADD(DAY, 3, OrderDate) AS [Pay Due],
DATEADD(MONTH, 1, OrderDate) AS [Deliver Due]
FROM Orders

--19
CREATE TABLE People
(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(50),
	Birthdate DATE
)

INSERT INTO People VALUES
('Victor', '2000-12-07'),
('Steven', '1992-09-10'),
('Stephen', '1910-09-19'),
('John', '2010-01-06')

SELECT [Name],
DATEDIFF(YEAR, Birthdate, GETDATE()) AS [Age in Years],
DATEDIFF(MONTH, Birthdate, GETDATE()) AS [Age in Months],
DATEDIFF(DAY, Birthdate, GETDATE()) AS [Age in Days],
DATEDIFF(MINUTE, Birthdate, GETDATE()) AS [Age in Minutes]
FROM People