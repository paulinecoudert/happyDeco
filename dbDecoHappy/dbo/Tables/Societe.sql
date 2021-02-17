CREATE TABLE [dbo].[Societe] (
    [idSociete] INT           IDENTITY (1, 1) NOT NULL,
    [nom]       NVARCHAR (50) NOT NULL,
    [TVA]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Societe] PRIMARY KEY CLUSTERED ([idSociete] ASC)
);

