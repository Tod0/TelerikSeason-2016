CREATE TABLE Users (
	UserID int IDENTITY PRIMARY KEY,
	Username nvarchar(50) NOT NULL UNIQUE,
	Password nvarchar(50) NOT NULL CHECK(LEN(Password) >= 5),
	FullName nvarchar(100) NOT NULL,
	LastLoginTime smalldatetime NOT NULL
)