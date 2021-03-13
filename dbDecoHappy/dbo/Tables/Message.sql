CREATE TABLE [dbo].[Message]
(
	[IdMessage] INT NOT NULL PRIMARY KEY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(323) NOT NULL, 
    [Phone] NVARCHAR(12) NOT NULL, 
    [Infomation] NVARCHAR(MAX) NOT NULL, 
    [DateEnvoie] DATE NOT NULL, 
    [NumeroProjet] INT NOT NULL
)
