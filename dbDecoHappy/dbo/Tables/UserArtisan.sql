CREATE TABLE [dbo].[UserArtisan] (
    [idUserArtisan]   INT            IDENTITY (1, 1) NOT NULL,
    [login]           NVARCHAR (50)  NOT NULL,
    [password]        NVARCHAR (50)  NOT NULL,
    [nom]             NVARCHAR (50)  NOT NULL,
    [prenom]          NVARCHAR (50)  NOT NULL,
    [metier]          NVARCHAR (MAX) NOT NULL,
    [dateDeNaissance] DATETIME       NOT NULL,
    [email]           NVARCHAR (50)  NOT NULL,
    [idSociete]       INT            NOT NULL,
    CONSTRAINT [PK_UserArtisan] PRIMARY KEY CLUSTERED ([idUserArtisan] ASC),
    CONSTRAINT [FK_UserArtisan_Societe] FOREIGN KEY ([idSociete]) REFERENCES [dbo].[Societe] ([idSociete])
);

