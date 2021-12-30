CREATE TABLE [dbo].[SubTasks]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] VARCHAR(50) NULL, 
    [Status] BIT NULL, 
    [SubId] INT NULL
)
