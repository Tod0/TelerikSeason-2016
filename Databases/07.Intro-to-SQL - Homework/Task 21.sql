SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name],
	m.LastName AS [Manager Last Name], 
	a.AddressText AS [Address]
FROM Employees e
JOIN Employees m
ON e.ManagerID = m.EmployeeID
JOIN Addresses a
ON e.AddressID = a.AddressID