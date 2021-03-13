CREATE TABLE [dbo].[UserClient] (
    [idUserClient]    INT            IDENTITY (1, 1) NOT NULL,
    [login]           NVARCHAR (50)  NOT NULL,
    [password]        NVARCHAR (500) NOT NULL,
    [nom]             NVARCHAR (50)  NOT NULL,
    [prenom]          NVARCHAR (50)  NOT NULL,
    [dateDeNaissance] DATE           NULL,
    [email]           NVARCHAR (50)  NOT NULL,
    [salt]            NVARCHAR (250) NULL,
    CONSTRAINT [PK_UserClient] PRIMARY KEY CLUSTERED ([idUserClient] ASC)
);



