SELECT e.FirstName + ' ' + e.LastName as [Full Name]
FROM Employees e
WHERE e.ManagerID IS NULL
