CREATE TABLE Persons (
	Id int IDENTITY PRIMARY KEY,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	SSN nvarchar(20) NOT NULL
)

CREATE TABLE Accounts (
	Id int IDENTITY PRIMARY KEY,
	PersonId int NOT NULL FOREIGN KEY REFERENCES Persons(Id),
	Balance decimal(19,4) NOT NULL
)