CREATE TABLE [dbo].[SubTasks] (
    [Title]  VARCHAR (50) NULL,
    [Status] BIT          NULL,
    [SubId]  INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([SubId])
);

