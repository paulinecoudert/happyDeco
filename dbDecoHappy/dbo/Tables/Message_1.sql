CREATE TABLE [dbo].[Message] (
    [IdMessage]   INT            NOT NULL,
    [Nom]         NVARCHAR (50)  NOT NULL,
    [Email]       NVARCHAR (323) NOT NULL,
    [Phone]       NVARCHAR (12)  NOT NULL,
    [Information] NVARCHAR (MAX) NOT NULL,
    [DateEnvoie]  DATETIME       NULL,
    CONSTRAINT [PK__Message__47AAF3043A9B817E] PRIMARY KEY CLUSTERED ([IdMessage] ASC)
);







