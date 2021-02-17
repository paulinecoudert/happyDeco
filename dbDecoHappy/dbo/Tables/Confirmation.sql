CREATE TABLE [dbo].[Confirmation] (
    [idConfirmation]   INT  IDENTITY (1, 1) NOT NULL,
    [dateConfirmation] DATE NOT NULL,
    [idUserArtisan]    INT  NOT NULL,
    [idProjet]         INT  NOT NULL,
    CONSTRAINT [PK_Confirmation] PRIMARY KEY CLUSTERED ([idConfirmation] ASC),
    CONSTRAINT [FK_Confirmation_Projet] FOREIGN KEY ([idProjet]) REFERENCES [dbo].[Projet] ([idProjet])
);

