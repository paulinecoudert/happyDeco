CREATE TABLE [dbo].[Validation] (
    [idValidation]   INT      IDENTITY (1, 1) NOT NULL,
    [dateValidation] DATETIME NOT NULL,
    [idUserClient]   INT      NOT NULL,
    [idUserArtisan]  INT      NOT NULL,
    CONSTRAINT [PK_Validation] PRIMARY KEY CLUSTERED ([idValidation] ASC),
    CONSTRAINT [FK_Validation_UserArtisan] FOREIGN KEY ([idUserArtisan]) REFERENCES [dbo].[UserArtisan] ([idUserArtisan]),
    CONSTRAINT [FK_Validation_UserClient1] FOREIGN KEY ([idUserClient]) REFERENCES [dbo].[UserClient] ([idUserClient])
);

