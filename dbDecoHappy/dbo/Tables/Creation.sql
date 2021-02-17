CREATE TABLE [dbo].[Creation] (
    [idCreation]   INT  IDENTITY (1, 1) NOT NULL,
    [dateCreation] DATE NOT NULL,
    [idUserClient] INT  NOT NULL,
    [idProjet]     INT  NOT NULL,
    CONSTRAINT [PK_Creation] PRIMARY KEY CLUSTERED ([idCreation] ASC),
    CONSTRAINT [FK_Creation_Projet] FOREIGN KEY ([idProjet]) REFERENCES [dbo].[Projet] ([idProjet]),
    CONSTRAINT [FK_Creation_UserClient] FOREIGN KEY ([idUserClient]) REFERENCES [dbo].[UserClient] ([idUserClient])
);

