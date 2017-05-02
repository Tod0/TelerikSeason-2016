USE Persons
GO

CREATE PROC dbo.usp_SelectPersonsWithMoreMoney(@money decimal(19,4))
AS
	SELECT p.FirstName, p.LastName,
		a.Balance
	FROM Persons p
	JOIN Accounts a
	ON p.Id = a.PersonId
	WHERE a.Balance > @money
GO