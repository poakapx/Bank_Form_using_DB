USE Bank

Drop Table [Bankappforadmin]
Drop Table [BankappforadminPasswordandLogin]

Create Table [Bankappforadmin]
(
	[ID]			INT				IDENTITY	NOT NULL	PRIMARY KEY,
	[First_Name]	NVARCHAR(50)	NOT NULL,
	[Surname]		NVARCHAR(50)	NOT NULL,
	[Middle_Name]	NVARCHAR(50)	NOT NULL,
	[Money]			MONEY			NULL
)

INSERT INTO [Bankappforadmin] ([First_Name], [Surname], [Middle_Name], [Money]) VALUES('Иван', 'Сирко', 'Дмитриевич', 23436)

SELECT * FROM [Bankappforadmin]

Create Table [BankappforadminPasswordandLogin]
(
	[Login]			NVARCHAR(50)	NOT NULL,
	[Password]		NVARCHAR(50)	NOT NULL
)

INSERT INTO [BankappforadminPasswordandLogin] ([Login], [Password]) VALUES('a', 'b')
INSERT INTO [BankappforadminPasswordandLogin] ([Login], [Password]) VALUES('Ocheretyinai_Pavlo', '^4J42-//')


SELECT * FROM BankappforadminPasswordandLogin