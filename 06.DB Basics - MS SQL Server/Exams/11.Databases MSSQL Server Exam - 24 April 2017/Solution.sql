CREATE DATABASE WMS
USE WMS
GO

--1
CREATE TABLE Clients(
	ClientID INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	Phone CHAR(12) NOT NULL
)

CREATE TABLE Mechanics(
	MechanicId INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	[Address] VARCHAR(255)
)
CREATE TABLE Models(
	ModelId INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL UNIQUE
)

CREATE TABLE Jobs(
	JobId INT PRIMARY KEY IDENTITY,
	ModelId INT FOREIGN KEY REFERENCES Models(ModelId) NOT NULL,
	[Status] VARCHAR(11) DEFAULT 'Pending' CHECK([Status] = 'Pending' OR [Status] = 'In Progress' OR [Status] = 'Finished'),
	ClientId INT FOREIGN KEY REFERENCES Clients(ClientID) NOT NULL,
	MechanicId INT FOREIGN KEY REFERENCES Mechanics(MechanicId),
	IssueDate DATE NOT NULL,
	FinishDate DATE
)

CREATE TABLE Orders(
	OrderId INT PRIMARY KEY IDENTITY,
	JobId INT FOREIGN KEY REFERENCES Jobs(JobId) NOT NULL,
	IssueDate DATE,
	Delivered BIT DEFAULT 0
)
CREATE TABLE Vendors(
	VendorId INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL UNIQUE
)

CREATE TABLE Parts(
	PartId INT PRIMARY KEY IDENTITY,
	SerialNumber VARCHAR(50) NOT NULL UNIQUE,
	[Description] VARCHAR(255),
	Price DECIMAL(6,2) NOT NULL CHECK(Price >= 1),
	VendorId INT FOREIGN KEY REFERENCES Vendors(VendorId) NOT NULL,
	StockQty INT DEFAULT 0 CHECK(StockQty >= 0)
)

CREATE TABLE OrderParts(
	OrderId INT FOREIGN KEY REFERENCES Orders(OrderId),
	PartId INT FOREIGN KEY REFERENCES Parts(PartId),
	Quantity INT DEFAULT 1 CHECK(Quantity >= 1)
	--CONSTRAINT PK_OrderParts PRIMARY KEY(OrderId, PartId)
)

CREATE TABLE PartsNeeded(
	JobId INT FOREIGN KEY REFERENCES Jobs(JobId),
	PartId INT FOREIGN KEY REFERENCES Parts(PartId),
	Quantity INT DEFAULT 1 CHECK(Quantity >= 1)
	--CONSTRAINT PK_PartsNeeded PRIMARY KEY(JobId, PartId)
)

--2
INSERT INTO Clients(FirstName,
                    LastName,
                    Phone
                   )
VALUES
(
       'Teri',
       'Ennaco',
       '570-889-5187'
),
(
       'Merlyn',
       'Lawler',
       '201-588-7810'
),
(
       'Georgene',
       'Montezuma',
       '925-615-5185'
),
(
       'Jettie',
       'Mconnell',
       '908-802-3564'
),
(
       'Lemuel',
       'Latzke',
       '631-748-6479'
),
(
       'Melodie',
       'Knipp',
       '805-690-1682'
),
(
       'Candida',
       'Corbley',
       '908-275-8357'
);

INSERT INTO Parts (SerialNumber, Description, Price, VendorId) VALUES
('WP8182119', 'Door Boot Seal', 117.86, 2),
('W10780048', 'Suspension Rod', 42.81, 1),
('W10841140', 'Silicone Adhesive', 6.77, 4),
('WPY055980', 'High Temperature Adhesive', 13.94, 3)

--3
UPDATE Jobs
SET MechanicId = 3, Status = 'In Progress'
WHERE Status = 'Pending'


--4
DELETE FROM OrderParts
WHERE OrderId = 19
DELETE FROM Orders
WHERE OrderId = 19

--5
SELECT FirstName, LastName, Phone FROM Clients
ORDER BY LastName, ClientID

--6
 SELECT Status, IssueDate FROM Jobs
 WHERE Status <> 'Finished'
 ORDER BY IssueDate, JobId

 --7
 SELECT CONCAT(m.FirstName, ' ', m.LastName) AS Mechanic, j.Status, j.IssueDate FROM Mechanics AS m
 JOIN Jobs AS j
 ON j.MechanicId = m.MechanicId
 ORDER BY m.MechanicId, j.IssueDate, j.JobId

 --8
 SELECT CONCAT(c.FirstName, ' ',c.LastName) AS Client, DATEDIFF(DAY, j.IssueDate, '2017-04-24') AS [Days Going], j.Status FROM Clients AS c
 JOIN Jobs AS j
 ON j.ClientId = c.ClientID
 WHERE j.Status <> 'Finished'
 ORDER BY [Days Going] DESC, c.ClientID

 --9
 SELECT CONCAT(c.FirstName, ' ', c.LastName) AS [Mechanic], AVG(DATEDIFF(DAY,j.IssueDate, j.FinishDate)) AS [AverageDays] FROM Mechanics AS c
 JOIN Jobs AS j
 ON j.MechanicId = c.MechanicId
 GROUP BY c.FirstName, c.LastName, c.MechanicId
 ORDER BY c.MechanicId

 --10
 SELECT TOP 3 CONCAT(m.FirstName, ' ', m.LastName) AS [Mechanic], COUNT(j.JobId) AS [Jobs] FROM Mechanics AS m
 JOIN Jobs AS j
 ON j.MechanicId = m.MechanicId
 WHERE j.Status <> 'Finished'
 GROUP BY m.FirstName, m.LastName, m.MechanicId
 HAVING COUNT(j.JobId) > 1
 ORDER BY [Jobs] DESC, m.MechanicId

 --11
SELECT CONCAT(m.FirstName, ' ', m.LastName) AS Available FROM Mechanics AS m
WHERE MechanicId NOT IN(SELECT MechanicId FROM Jobs WHERE Status <> 'Finished' AND MechanicId IS NOT NULL)
ORDER BY m.MechanicId

--12
SELECT ISNULL(SUM(p.Price * op.Quantity), 0) AS [Parts Total] FROM Parts AS  p
JOIN OrderParts AS op
ON op.PartId = p.PartId
JOIN Orders AS o
ON o.OrderId = op.OrderId
WHERE DATEDIFF(WEEK, o.IssueDate, '2017-04-24') <= 3

--13
SELECT j.JobId, ISNULL(SUM(p.Price * op.Quantity), 0) AS [Total] FROM Jobs AS j
LEFT JOIN Orders AS o
ON o.JobId = j.JobId
LEFT JOIN OrderParts op
ON op.OrderId = o.OrderId
LEFT JOIN Parts AS p
ON p.PartId = op.PartId
WHERE j.Status = 'Finished'
GROUP BY j.JobId
ORDER BY Total DESC, j.JobId

--14
SELECT m.ModelId, m.Name, CAST(AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate)) AS varchar) + ' days'  AS [Average Service Time]FROM Models AS m
LEFT JOIN Jobs AS j
ON j.ModelId = m.ModelId
GROUP BY m.ModelId, m.Name
ORDER BY AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate))

--15
SELECT TOP 1 WITH TIES m.Name, COUNT(j.JobId) AS [Times Servised],
(
SELECT ISNULL(SUM(p.Price * op.Quantity), 0) FROM Orders AS o
JOIN OrderParts AS op
ON op.OrderId = o.OrderId
JOIN Parts AS p
ON p.PartId = op.PartId
JOIN Jobs AS j
ON j.JobId = o.JobId
WHERE j.ModelId = m.ModelId
) AS [Parts Total]
FROM Models AS m
JOIN Jobs AS j
ON j.ModelId = m.ModelId 
GROUP BY m.Name, m.ModelId
ORDER BY [Times Servised] DESC

--16
SELECT p.PartId, p.Description, SUM(pn.Quantity), SUM(p.StockQty), ISNULL(SUM(op.Quantity), 0) FROM Parts AS p
JOIN PartsNeeded AS pn
ON pn.PartId = p.PartId
JOIN Jobs AS j
ON j.JobId = pn.JobId
LEFT JOIN Orders AS o
ON o.JobId = j.JobId
LEFT JOIN OrderParts AS op
ON op.OrderId = o.OrderId
WHERE j.Status <> 'Finished'
GROUP BY p.PartId, p.Description
HAVING SUM(pn.Quantity) > SUM(p.StockQty) + ISNULL(SUM(op.Quantity), 0)
ORDER BY p.PartId
GO

--17
CREATE FUNCTION udf_GetCost (@jobId INT)
RETURNS DECIMAL(14,2)
BEGIN
DECLARE @totalCost DECIMAL(14,2) =
(SELECT SUM(p.Price * op.Quantity) FROM Jobs AS j
JOIN Orders AS o 
ON o.JobId = j.JobId
JOIN OrderParts AS op
ON op.OrderId = o.OrderId
JOIN Parts AS p
ON p.PartId = op.PartId
WHERE j.JobId = @jobId)
IF (@totalCost IS NULL)
BEGIN
RETURN 0
END
RETURN @totalCost
END
GO

SELECT dbo.udf_GetCost (1)
GO
--18
CREATE PROCEDURE usp_PlaceOrder 
(
	@jobId INT,
	@serialNumber VARCHAR(50),
	@quantity INT
) AS
BEGIN
	DECLARE @partId INT = (SELECT PartId from Parts WHERE SerialNumber = @serialNumber)
	DECLARE @orderId INT = (SELECT TOP 1OrderId FROM Orders WHERE JobId = @jobId AND IssueDate IS NULL)

	IF (@quantity <= 0)
	BEGIN
		;THROW 50012, 'Part quantity must be more than zero!', 1
	END
	IF ((SELECT JobId FROM Jobs WHERE JobId = @jobId AND Status = 'Finished') IS NOT NULL)
	BEGIN
		;THROW 50011, 'This job is not active!', 1
	END
	IF((SELECT JOBId FROM Jobs WHERE JobId = @jobId) IS NULL)
	BEGIN
		;THROW 50013, 'Job not found!', 1
	END
	IF(@partId IS NULL)
	BEGIN
		;THROW 50014, 'Part not found!', 1
	END
	IF(@orderId IS NULL)
	BEGIN
		INSERT INTO Orders(JobId, IssueDate) VALUES (@jobId, NULL)
		DECLARE @Id INT = (SELECT TOP 1 OrderId FROM Orders WHERE JobId = @jobId)
		INSERT INTO OrderParts(OrderId, PartId, Quantity) VALUES (@id, @partId, @quantity)
	END	
	ELSE
	BEGIN
		IF((SELECT PartId FROM OrderParts WHERE OrderId = @orderId AND PartId = @partId) IS NOT NULL)
		BEGIN
			UPDATE OrderParts
			SET Quantity += @quantity
			WHERE OrderId = @orderId AND PartId = @partId
		END
		ELSE
		BEGIN
			INSERT INTO OrderParts(OrderId, PartId, Quantity) VALUES(@orderId, @partId, @quantity)
		END
	END
END
GO

--19
CREATE TRIGGER tr_UpdateQty ON Orders FOR UPDATE AS
UPDATE Parts
SET StockQty += op.Quantity
FROM Parts AS p
JOIN OrderParts AS op
ON op.PartId = p.PartId
JOIN Orders AS o
ON o.OrderId = op.OrderId
JOIN inserted AS i
ON i.OrderId = o.OrderId
JOIN deleted AS d
ON d.OrderId = i.OrderId

--20
