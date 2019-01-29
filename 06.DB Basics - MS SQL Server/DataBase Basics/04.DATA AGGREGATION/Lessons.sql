SELECT * FROM Employees

SELECT DepartmentID, SUM(Salary)
FROM Employees
GROUP BY DepartmentID

SELECT e.ManagerID FROM Employees AS e
GROUP BY e.ManagerID 

SELECT DepartmentID, SUM(Salary) AS SumSalary
FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID ASC

SELECT Salary, SUM(Salary) OVER (ORDER BY EmployeeID)
FROM Employees