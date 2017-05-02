SELECT COUNT(*) as [Employee Count],
	d.Name as [Department Name],
	t.Name as [Town Name]
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
JOIN Addresses a ON e.AddressID = a.AddressID
JOIN Towns t ON a.TownID = t.TownID
GROUP BY d.Name, t.Name