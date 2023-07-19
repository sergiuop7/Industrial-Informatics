CREATE TABLE [dbo].[Biblioteca] (
    [Id]              INT  NOT NULL,
    [Titlu]           TEXT NULL,
    [Autor]           TEXT NULL,
    [Editura]         TEXT NULL,
    [Anul publicarii] INT  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

