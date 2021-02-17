CREATE TABLE [dbo].[Statut] (
    [idStatut] INT           IDENTITY (1, 1) NOT NULL,
    [libellé]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Statut] PRIMARY KEY CLUSTERED ([idStatut] ASC)
);

