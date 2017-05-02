SELECT Count(*) as [Employees With Manager] 
FROM Employees e
WHERE e.ManagerID IS NOT NULL