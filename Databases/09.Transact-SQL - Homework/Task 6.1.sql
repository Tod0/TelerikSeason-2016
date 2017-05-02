CREATE TABLE Logs (
	Id int IDENTITY PRIMARY KEY,
	AccountId int FOREIGN KEY REFERENCES Accounts(Id),
	OldSum decimal(19,4),
	NewSum decimal(19,4) 
)