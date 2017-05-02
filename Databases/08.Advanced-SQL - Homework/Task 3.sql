SELECT e.FirstName + ' ' + e.LastName as [Full Name], e.DepartmentID, e.Salary
FROM Employees e
WHERE Salary = 
  (SELECT MIN(Salary) FROM Employees 
   WHERE DepartmentID = e.DepartmentID)
ORDER BY DepartmentID