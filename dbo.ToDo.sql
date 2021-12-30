CREATE TABLE [dbo].[ToDo] (
    [Id]         INT          NOT NULL,
    [Title]      VARCHAR (50) NULL,
    [Date]       DATETIME     NULL,
    [Progress]   INT          DEFAULT ((0)) NOT NULL,
    [Priority]   INT          DEFAULT ((0)) NOT NULL,
    [Category]   INT          DEFAULT ((0)) NOT NULL,
    [Amount]     VARCHAR (50) DEFAULT ((0)) NULL,
    [Completion] INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

