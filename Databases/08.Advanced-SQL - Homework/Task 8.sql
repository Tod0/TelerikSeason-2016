SELECT Count(*) as [Employees Without Manager] 
FROM Employees e
WHERE e.ManagerID IS NULL