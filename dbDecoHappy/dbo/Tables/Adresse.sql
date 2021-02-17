CREATE TABLE [dbo].[Adresse] (
    [idAdresse]     INT           IDENTITY (1, 1) NOT NULL,
    [rue]           NVARCHAR (50) NULL,
    [numero]        NVARCHAR (50) NULL,
    [codePostal]    INT           NOT NULL,
    [ville]         NVARCHAR (50) NOT NULL,
    [idUserClient]  INT           NOT NULL,
    [idUserArtisan] INT           NOT NULL,
    CONSTRAINT [PK_Adresse] PRIMARY KEY CLUSTERED ([idAdresse] ASC),
    CONSTRAINT [FK_Adresse_UserArtisan] FOREIGN KEY ([idUserArtisan]) REFERENCES [dbo].[UserArtisan] ([idUserArtisan]),
    CONSTRAINT [FK_Adresse_UserClient] FOREIGN KEY ([idUserClient]) REFERENCES [dbo].[UserClient] ([idUserClient])
);

