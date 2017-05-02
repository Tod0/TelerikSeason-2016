SELECT e.EmployeeID, e.LastName, e.AddressID, 
       a.AddressID, a.AddressText AS [Address]
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID