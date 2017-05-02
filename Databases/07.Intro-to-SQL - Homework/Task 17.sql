SELECT TOP 5 e.FirstName + ' ' + e.LastName as [Full Name], e.Salary
FROM Employees e
ORDER BY e.Salary DESC