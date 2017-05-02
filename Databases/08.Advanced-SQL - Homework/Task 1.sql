SELECT e.FirstName, e.LastName, e.Salary
FROM Employees e
WHERE Salary = 
  (SELECT MIN(Salary) FROM Employees)