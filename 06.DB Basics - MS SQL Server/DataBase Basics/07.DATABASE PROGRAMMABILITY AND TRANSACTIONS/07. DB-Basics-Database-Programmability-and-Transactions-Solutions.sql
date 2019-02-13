--1
USE SoftUni
GO

CREATE PROC usp_GetEmployeesSalaryAbove35000 AS 
	SELECT FirstName, LastName FROM Employees
	WHERE Salary > 35000
GO

--2
CREATE PROC usp_GetEmployeesSalaryAboveNumber @inputNumber DECIMAL(18,4) AS
	SELECT FirstName, LastName FROM Employees
	WHERE salary >= @inputNumber

EXEC usp_GetEmployeesSalaryAboveNumber 30000
GO

--3
CREATE PROC usp_GetTownsStartingWith  @input VARCHAR(MAX) AS
	SELECT [Name] FROM Towns
	WHERE [Name] LIKE @input + '%'

EXEC usp_GetTownsStartingWith 'bor'
GO

--4
CREATE PROC usp_GetEmployeesFromTown @townName VARCHAR(MAX) AS
	SELECT e.FirstName, e.LastName FROM Employees AS e
	JOIN Addresses AS a
	ON a.AddressID = e.AddressID
	JOIN Towns AS t
	ON t.TownID = a.TownID
	WHERE t.[Name] = @townName

EXEC usp_GetEmployeesFromTown 'Sofia'
GO

--5
CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4)) 
	RETURNS CHAR(10)
	BEGIN
	DECLARE @salaryLevel CHAR(10)
	IF(@salary < 30000)
		BEGIN SET @salaryLevel = 'Low' END
	ELSE IF(@salary BETWEEN 30000 AND 50000)
		BEGIN SET @salaryLevel = 'Average' END
	ELSE
		BEGIN SET @salaryLevel = 'High' END
	RETURN @salaryLevel
	END

GO

SELECT dbo.ufn_GetSalaryLevel(20000)

SELECT Salary, dbo.ufn_GetSalaryLevel(Salary) AS SalaryLevel
FROM Employees
GO
--6
CREATE PROC usp_EmployeesBySalaryLevel @salaryLevel CHAR(10) AS
	SELECT FirstName, LastName FROM Employees
	WHERE dbo.ufn_GetSalaryLevel(Salary) = @salaryLevel

EXEC usp_EmployeesBySalaryLevel 'High'
GO

--7
CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
	BEGIN
		DECLARE @count INT = 1
		WHILE (@count <= LEN(@word))
		BEGIN
			DECLARE @currentLetter CHAR(1) = SUBSTRING(@word, @count, 1)
			DECLARE @charIndex INT = CHARINDEX(@currentLetter, @setOfLetters)
			IF (@charIndex = 0)
			BEGIN
				RETURN 0
			END
			SET @count += 1
		END
	RETURN 1
END
GO

SELECT dbo.ufn_IsWordComprised('asdedsads', 'f')
GO

--8
CREATE PROC usp_DeleteEmployeesFromDepartment (@departmentId INT)
AS
BEGIN
	DELETE FROM EmployeesProjects
	WHERE EmployeeID IN
	(
		SELECT EmployeeID FROM Employees
		WHERE DepartmentID = @departmentId
	)

	ALTER TABLE Departments
	ALTER COLUMN ManagerId INT NULL

	UPDATE Departments
	SET ManagerID = NULL
	WHERE ManagerID IN
	(
		SELECT EmployeeID FROM Employees
		WHERE DepartmentID = @departmentId
	)

	UPDATE Employees
	SET ManagerID = NULL
	WHERE ManagerID IN
	(
		SELECT EmployeeID FROM Employees
		WHERE DepartmentID = @departmentId
	)

	DELETE FROM Employees
	WHERE DepartmentID = @departmentId

	DELETE FROM Departments
	WHERE DepartmentID = @departmentId

	SELECT COUNT(*) FROM Employees
	WHERE DepartmentID = @departmentId
END
GO

--9
USE Bank
GO

CREATE PROC usp_GetHoldersFullName AS
	SELECT FirstName + ' ' + LastName AS [FullName] FROM AccountHolders
GO

EXEC usp_GetHoldersFullName
GO

--10
CREATE PROC usp_GetHoldersWithBalanceHigherThan @inputnumber DECIMAL(18,4) AS
	SELECT k.FirstName, k.LastName FROM(
		SELECT ah.Id, ah.FirstName, ah.LastName FROM AccountHolders AS ah
		JOIN Accounts AS a
		ON a.AccountHolderId = ah.Id
		GROUP BY ah.Id, ah.FirstName, ah.LastName
		HAVING SUM(a.Balance) > @inputnumber) AS k
	ORDER BY k.FirstName, k.LastName
GO
--11
CREATE FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(18,4), @yearlyInterestRate FLOAT, @numberOfYear INT)
	RETURNS DECIMAL(18,4)
	BEGIN
		RETURN @sum * POWER((1 + @yearlyInterestRate), @numberOfYear)
	END
GO
SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)
GO

--12
CREATE PROC usp_CalculateFutureValueForAccount @accountId INT, @interestRate FLOAT AS
	SELECT a.Id, ah.FirstName, ah.LastName, a.Balance, dbo.ufn_CalculateFutureValue(a.Balance, @interestRate, 5) FROM Accounts AS a
	JOIN AccountHolders AS ah
	ON ah.Id = a.AccountHolderId
	WHERE a.Id = @accountId

EXEC usp_CalculateFutureValueForAccount 1, 0.1
GO
--13
USE Diablo
GO

CREATE FUNCTION ufn_CashInUsersGames (@gameName VARCHAR(mAX))
RETURNS TABLE
RETURN (SELECT SUM(k.Cash) AS TotalCash FROM(
	SELECT g.Name, ug.Cash, ROW_NUMBER() OVER (ORDER BY Cash DESC) AS RowNumber FROM Games g
		JOIN UsersGames AS ug
		ON ug.GameId = g.Id
		WHERE g.Name = @gameName) AS k
	WHERE k.RowNumber % 2 = 1)
GO

SELECT * FROM dbo.ufn_CashInUsersGames('Love in a Mist')

--14
USE Bank
GO

CREATE TABLE Logs
(
	LogId INT PRIMARY KEY IDENTITY,
	AccountId INT NOT NULL,
	OldSum DECIMAL (8, 2),
	NewSum DECIMAL (8, 2)
)
GO

CREATE TRIGGER tr_LogsUpdate ON Accounts AFTER UPDATE AS
BEGIN
	INSERT INTO Logs(AccountId, OldSum, NewSum)
	SELECT i.Id, d.Balance, i.Balance FROM inserted	AS i
	INNER JOIN deleted AS d
	ON i.AccountHolderId = d.AccountHolderId
END

UPDATE Accounts SET Balance = 150 WHERE Id = 1
SELECT * FROM Logs

--15
CREATE TABLE NotificationEmails
(
	Id INT PRIMARY KEY IDENTITY,
	Recipient INT NOT NULL,
	[Subject] NVARCHAR(MAX),
	Body NVARCHAR(MAX)
)
GO
CREATE TRIGGER tr_MailCreator ON Logs AFTER INSERT
AS
BEGIN
	DECLARE @Recipient INT = (SELECT LogId FROM Logs)
	DECLARE @Subject NVARCHAR(MAX) = 'Balance change for account: ' + 
		CONVERT(NVARCHAR(50), (SELECT LogId FROM Logs))
	DECLARE @Body NVARCHAR(MAX) = 'On ' + CONVERT(NVARCHAR(50), GETDATE()) + 
		' your balance was changed from ' + CONVERT(NVARCHAR(50), (SELECT OldSum FROM Logs)) + 
		' to ' + CONVERT(NVARCHAR(50), (SELECT NewSum FROM Logs)) + '.'

	INSERT INTO NotificationEmails VALUES
	(@Recipient, @Subject, @Body)
END
GO

--16
CREATE PROCEDURE usp_DepositMoney (@AccountId INT, @MoneyAmount DECIMAL(15, 4))
AS
BEGIN
	UPDATE Accounts
	SET Balance += @MoneyAmount
	WHERE Id = @AccountId
END
GO

--17
CREATE PROCEDURE usp_WithdrawMoney (@AccountId INT, @MoneyAmount DECIMAL(15, 4))
AS
BEGIN
	UPDATE Accounts
	SET Balance -= @MoneyAmount
	WHERE Id = @AccountId
END
GO

--18
CREATE PROCEDURE usp_TransferMoney(@SenderId INT, @ReceiverId INT, @Amount DECIMAL(15, 4))
AS
BEGIN
	BEGIN TRANSACTION
		EXEC dbo.usp_WithdrawMoney @SenderId, @Amount
		EXEC dbo.usp_DepositMoney @ReceiverId, @Amount
		IF 
		(
			SELECT Balance 
			  FROM Accounts
			 WHERE Accounts.Id = @SenderId
		) < 0
		BEGIN
			ROLLBACK
		END
		ELSE
		BEGIN
		COMMIT
	END
END
GO

--20
USE Diablo
GO

BEGIN TRANSACTION
DECLARE @sum1 MONEY = (SELECT SUM(i.Price)
						FROM Items i
						WHERE MinLevel BETWEEN 11 AND 12)

IF (SELECT Cash FROM UsersGames WHERE Id = 110) < @sum1 --hardcoding for the win
ROLLBACK
ELSE BEGIN
		UPDATE UsersGames
		SET Cash -= @sum1
		WHERE Id = 110

		INSERT INTO UserGameItems (UserGameId, ItemId)
		SELECT 110, Id 
		FROM Items 
		WHERE MinLevel BETWEEN 11 AND 12
		COMMIT
	END

BEGIN TRANSACTION
DECLARE @sum2 MONEY = (SELECT SUM(i.Price)
						FROM Items i
						WHERE MinLevel BETWEEN 19 AND 21)

IF (SELECT Cash FROM UsersGames WHERE Id = 110) < @sum2
ROLLBACK
ELSE BEGIN
		UPDATE UsersGames
		SET Cash -= @sum2
		WHERE Id = 110

		INSERT INTO UserGameItems (UserGameId, ItemId)
			SELECT 110, Id 
			FROM Items 
			WHERE MinLevel BETWEEN 19 AND 21
		COMMIT
	END

SELECT i.[Name] AS 'Item Name' 
FROM UserGameItems ugi
INNER JOIN Items AS i
ON ugi.ItemId = i.Id
WHERE ugi.UserGameId = 110

--21
USE SoftUni
GO

CREATE PROCEDURE usp_AssignProject (@employeeId INT, @projectID INT)
AS
BEGIN
	BEGIN TRANSACTION
	INSERT INTO EmployeesProjects VALUES (@employeeId, @projectID)
	IF
	(
	SELECT COUNT(ProjectID)
	FROM EmployeesProjects
	WHERE EmployeeID = @employeeId
	) > 3
	BEGIN
		RAISERROR('The employee has too many projects!', 16, 1)
		ROLLBACK
		RETURN
	END
	COMMIT
END

--22
CREATE TABLE Deleted_Employees
(
	EmployeeId INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	MiddleName VARCHAR(50),
	JobTitle VARCHAR(50),
	DepartmentId INT,
	Salary DECIMAL (15, 2)
)
GO

CREATE TRIGGER tr_DeleteEmployee ON Employees
AFTER DELETE 
AS
BEGIN
	INSERT INTO Deleted_Employees
	SELECT FirstName, LastName, MiddleName, JobTitle, DepartmentID, Salary 
	FROM deleted
END
GO

DELETE FROM Employees
WHERE EmployeeID = 293