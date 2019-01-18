--2. Create Table
CREATE TABLE Clients (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE AccountTypes (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE Accounts (
	Id INT PRIMARY KEY IDENTITY,
	AccountTypeId INT FOREIGN KEY REFERENCES AccountTypes(Id),
	Balance DECIMAL(15, 2) NOT NULL DEFAULT(0),
	ClientId INT FOREIGN KEY REFERENCES Clients(Id)
)
GO

--3. Insert Sample Data into Database
INSERT INTO Clients (FirstName, LastName) VALUES
('Stoqn', 'Petrov'),
('Krasimir', 'Nedelchev'),
('Teodor', 'Dimitrov'),
('Dimitar', 'Stoqnov')
GO

INSERT INTO AccountTypes (Name) VALUES
('Credit'),
('Debit')
GO

INSERT INTO Accounts (ClientId, AccountTypeId, Balance) VALUES
(1, 1, 75.45),
(2, 2, 175.13),
(2, 2, 83.55),
(3, 1, 56.07),
(4, 1, 765.70),
(4, 2, 44.45)

GO 
--4. Create a View
CREATE VIEW v_ClientBalances AS
SELECT (FirstName + ' ' + LastName) AS [Name],
  (AccountTypes.Name) AS [Account Type], Balance 
FROM Clients
JOIN Accounts ON Clients.Id = Accounts.ClientId
JOIN AccountTypes ON AccountTypes.Id = Accounts.AccountTypeId
GO

SELECT * FROM v_ClientBalances
GO

--5. Create a Function
CREATE FUNCTION f_CalculateTotalBalance (@ClientId INT)
RETURNS DECIMAL(15,2)
BEGIN
	DECLARE @result	AS DECIMAL(15,2) = (
		SELECT SUM(Balance)
		FROM Accounts WHERE ClientId = @ClientId
	)
	RETURN @result
END
GO

SELECT dbo.f_CalculateTotalBalance(2) AS Balance
GO

--6. Create Procedures
CREATE PROC p_AddAccount @ClientId INT, @AccountTypeId INT AS
INSERT INTO Accounts (ClientId, AccountTypeId) 
VALUES (@ClientId, @AccountTypeId)
GO

EXEC p_AddAccount 1, 1 
GO

SELECT * FROM Accounts
GO

CREATE PROCEDURE p_Deposit @AccountId INT, @Amount DECIMAL(15, 2) AS
UPDATE Accounts
SET Balance +=@Amount
WHERE Id = @AccountId
GO

EXEC p_Deposit 6, 9999
GO

SELECT * FROM Accounts
GO

CREATE PROCEDURE p_Withdraw @AccountId INT, @Amount DECIMAL(15, 2) AS
BEGIN
	DECLARE @OldBalance DECIMAL(15, 2)
	SELECT @OldBalance = Balance FROM Accounts WHERE Id = @AccountId
	IF (@OldBalance - @Amount >= 0)
	BEGIN
		UPDATE Accounts
		SET Balance -= @Amount
		WHERE Id = @AccountId
	END
	ELSE
	BEGIN
		RAISERROR('Not Enough Minerals', 10, 1)
	END
END
GO

EXEC p_Withdraw 2, 1000
GO

SELECT * FROM Accounts
GO

EXEC p_Withdraw 1, 9999999999 /*this will show up Not Enough Minerals, but in the console*/
GO

--7. Create Transactions Table and a Trigger
CREATE TABLE Transactions (
	Id INT PRIMARY KEY IDENTITY,
	AccountId INT FOREIGN KEY REFERENCES Accounts(Id),
	OldBalance DECIMAL(15, 2) NOT NULL,
	NewBalance DECIMAL(15, 2) NOT NULL,
	Amount AS NewBalance - OldBalance,
	[DateTime] DATETIME2
)
GO

CREATE TRIGGER tr_Transaction ON Accounts
AFTER UPDATE
AS
	INSERT INTO Transactions (AccountId, OldBalance, NewBalance, [DateTime])
	SELECT inserted.Id, deleted.Balance, inserted.Balance, GETDATE() FROM inserted
	JOIN deleted ON inserted.Id = deleted.Id
GO

SELECT * FROM Transactions
GO

EXEC p_Deposit 6, 9999
GO

EXEC p_Withdraw 2, 1000
GO

SELECT * FROM Transactions
GO


--NOTE! The input data is not the same as in word document, because I try with my own values :)
