CREATE TABLE [dbo].[Projet] (
    [idProjet]    INT            IDENTITY (1, 1) NOT NULL,
    [nom]         NVARCHAR (50)  NOT NULL,
    [description] NVARCHAR (MAX) NOT NULL,
    [piece]       NVARCHAR (50)  NOT NULL,
    [budget]      FLOAT (53)     NOT NULL,
    [image]       NVARCHAR (50)  NULL,
    [dateDeDebut] DATE           NOT NULL,
    [dateDeFin]   DATE           NOT NULL,
    CONSTRAINT [PK_Projet] PRIMARY KEY CLUSTERED ([idProjet] ASC)
);



