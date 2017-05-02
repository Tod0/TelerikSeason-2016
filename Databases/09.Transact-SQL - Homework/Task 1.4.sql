USE Persons
Go

CREATE PROC dbo.usp_SelectPersonsFullName
AS
	SELECT p.FirstName + ' ' + p.LastName as [FullName]
	FROM Persons p
GO