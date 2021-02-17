CREATE TABLE [dbo].[UserClient] (
    [idUserClient]    INT           IDENTITY (1, 1) NOT NULL,
    [login]           NVARCHAR (50) NOT NULL,
    [password]        NVARCHAR (50) NOT NULL,
    [nom]             NVARCHAR (50) NOT NULL,
    [prenom]          NVARCHAR (50) NOT NULL,
    [dateDeNaissance] DATE          NOT NULL,
    [email]           NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_UserClient] PRIMARY KEY CLUSTERED ([idUserClient] ASC)
);

