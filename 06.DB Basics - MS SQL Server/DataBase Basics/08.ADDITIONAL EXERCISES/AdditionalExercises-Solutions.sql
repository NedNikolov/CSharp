--1
USE Diablo
GO

SELECT SUBSTRING(Email, CHARINDEX('@', Email, 1) + 1, LEN(Email) + 1 - CHARINDEX('@', Email, 1)) AS [Email Provider],
COUNT(Email) AS [Number of Users] FROM Users
GROUP BY SUBSTRING(Email, CHARINDEX('@', Email, 1) + 1, LEN(Email) + 1 - CHARINDEX('@', Email, 1))
ORDER BY [Number of Users] DESC, [Email Provider]

--2
SELECT g.[Name], gt.[Name], u.Username, ug.[Level], ug.Cash, ch.[Name] FROM Games AS g
	INNER JOIN GameTypes AS gt
	ON gt.Id = g.GameTypeId
	INNER JOIN UsersGames AS ug
	ON ug.GameId = g.Id
	INNER JOIN Users AS u
	ON u.Id = ug.UserId
	INNER JOIN Characters AS ch
	ON ch.Id = ug.CharacterId
	ORDER BY ug.[Level] DESC, u.Username, g.[Name] 

--3
