CREATE TABLE [dbo].[Link]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] VARCHAR(50) NULL, 
    [Link] VARCHAR(256) NULL, 
    [TaskId] INT NULL
)
