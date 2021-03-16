CREATE TABLE [dbo].[Message] (
    [IdMessage]   INT            IDENTITY (1, 1) NOT NULL,
    [Nom]         NVARCHAR (50)  NOT NULL,
    [Email]       NVARCHAR (323) NOT NULL,
    [Phone]       NVARCHAR (12)  NOT NULL,
    [Information] NVARCHAR (MAX) NOT NULL,
    [DateEnvoie]  DATETIME       NOT NULL,
    CONSTRAINT [PK__Message__47AAF3043A9B817E] PRIMARY KEY CLUSTERED ([IdMessage] ASC)
);









