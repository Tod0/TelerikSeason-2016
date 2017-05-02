SELECT e.LastName AS [Employee Last Name],
       m.EmployeeID AS [Manager ID], m.LastName AS [Manager Last Name]
FROM Employees e RIGHT OUTER JOIN Employees m
  ON e.ManagerID = m.EmployeeID