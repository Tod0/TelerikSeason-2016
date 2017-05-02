SELECT d.Name AS [Name]
FROM Departments d
UNION
SELECT t.Name AS [Name]
FROM Towns t
