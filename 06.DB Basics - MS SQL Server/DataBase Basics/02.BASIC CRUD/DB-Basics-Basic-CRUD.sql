--2
USE SoftUni
GO

SELECT * FROM Departments

--3
SELECT Name FROM Departments

--4
SELECT FirstName, LastName, Salary FROM Employees

--5
SELECT FirstName, MiddleName, LastName FROM Employees

--6
SELECT FirstName + '.' + LastName + '@softuni.bg' 
AS [Full Email Address]
FROM Employees

--7
SELECT DISTINCT Salary FROM Employees

--8
SELECT * FROM Employees
WHERE JobTitle = 'Sales Representative'

--9
SELECT FirstName, LastName, JobTitle FROM Employees
--WHERE Salary > 20000 and Salary < 30000 -- Zero points in Judge, but working :D
WHERE Salary BETWEEN 20000 and 30000

--10
SELECT FirstName + ' ' + MiddleName + ' ' + LastName
AS [Full Name]
FROM Employees
WHERE Salary = 12500 or Salary = 14000 or Salary = 23600 or Salary = 25000

--11
SELECT FirstName, LastName FROM Employees
WHERE ManagerID IS NULL

--12
SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC

--13
SELECT TOP 5 FirstName, LastName FROM Employees
ORDER BY Salary DESC

--14
SELECT FirstName, LastName FROM Employees
WHERE DepartmentID != 4

--15
SELECT * FROM Employees
ORDER BY Salary DESC, FirstName, LastName DESC, MiddleName
GO

--16
CREATE VIEW v_EmployeesSalaries AS
SELECT FirstName, LastName, Salary FROM Employees
GO

SELECT * FROM v_EmployeesSalaries
GO

--17
CREATE VIEW v_EmployeeNameJobTitle AS
SELECT FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName AS [FullName], JobTitle AS [Job Title] FROM Employees
GO

SELECT * FROM v_EmployeeNameJobTitle
GO

--18
SELECT DISTINCT JobTitle FROM Employees --''SELECT DISTINCT'' returns only different values
ORDER BY JobTitle

--19
SELECT TOP 10 * FROM Projects
ORDER BY StartDate, Name

--20
SELECT TOP 7 FirstName, LastName, HireDate FROM Employees
ORDER BY HireDate DESC

--21
UPDATE Employees
SET Salary *= 1.12
WHERE DepartmentID = 1 OR DepartmentID = 2 OR DepartmentID = 4 OR DepartmentID = 11

SELECT Salary FROM Employees

--22
--change to DB Georgaphy or use 'USE Geography'
USE Geography
GO

SELECT PeakName FROM Peaks
ORDER BY PeakName

--23
SELECT TOP 30 CountryName, Population FROM Countries
WHERE ContinentCode = 'EU'
ORDER BY Population DESC, CountryName

--24
SELECT CountryName, CountryCode, (CASE WHEN CurrencyCode = 'EUR' THEN 'Euro' ELSE 'Not Euro' END) AS [Currency] FROM Countries
ORDER BY CountryName

--25
USE Diablo
GO

SELECT Name FROM Characters
ORDER BY Name