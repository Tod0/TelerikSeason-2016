SELECT AVG(Salary) as [Average Salary],
	d.Name as [Department Name]
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name