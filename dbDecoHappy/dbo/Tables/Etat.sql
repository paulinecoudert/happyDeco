CREATE TABLE [dbo].[Etat] (
    [idEtat]   INT  IDENTITY (1, 1) NOT NULL,
    [date]     DATE NOT NULL,
    [idStatut] INT  NOT NULL,
    [idProjet] INT  NOT NULL,
    CONSTRAINT [PK_Etat] PRIMARY KEY CLUSTERED ([idEtat] ASC),
    CONSTRAINT [FK_Etat_Projet] FOREIGN KEY ([idProjet]) REFERENCES [dbo].[Projet] ([idProjet]),
    CONSTRAINT [FK_Etat_Statut] FOREIGN KEY ([idStatut]) REFERENCES [dbo].[Statut] ([idStatut])
);

