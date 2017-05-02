USE Persons
GO

CREATE PROC dbo.usp_WithdrawMoney(@accountId int, @money decimal(19,4))
AS
	BEGIN
		UPDATE Accounts
		SET Balance = Balance - @money
		WHERE Id = @accountId
	END
GO