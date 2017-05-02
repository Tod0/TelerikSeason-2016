SELECT e.EmployeeID, e.LastName, e.AddressID,
       a.AddressID, a.AddressText AS [Address]
FROM Employees e 
  INNER JOIN Addresses a
    ON e.AddressID = a.AddressID