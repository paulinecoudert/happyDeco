CREATE PROCEDURE [dbo].[SP_Adresse_Insert]

	@rue NVARCHAR(50),
	@numero NVARCHAR(50),
	@codePostal INT,
	@ville NVARCHAR(50),
	
	@nom NVARCHAR (50),
	@prenom NVARCHAR (50),
	@dateDeNaissance DATE,
	@email NVARCHAR (50) ,

	@login NVARCHAR(50),
	@password NVARCHAR(500)
AS
DECLARE @idUserClient INT, @salt NVARCHAR(250)
	SET @salt = [dbo].SF_GenerateSalt()
	INSERT INTO[UserClient]([Nom], [Prenom], [DateDeNaissance], [Email], [Login], [Password], [Salt])
	VALUES (@nom, @prenom, @dateDeNaissance, @email, @login,dbo.SF_EncryptedPassword(@password, @salt),@salt)
	SET @idUserClient = @@IDENTITY

	INSERT INTO[Adresse]([Numero], [Rue], [Ville], [CodePostal],[IdUserClient] )
	OUTPUT inserted.IdAdresse
	VALUES (@numero, @rue, @ville, @codePostal, @idUserClient)