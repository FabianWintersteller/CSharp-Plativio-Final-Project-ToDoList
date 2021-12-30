CREATE TABLE [dbo].[ToDo]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] VARCHAR(50) NULL, 
    [Due Date] DATE NULL, 
    [Progress] INT NULL, 
    [Priority] INT NULL, 
    [Category] INT NULL, 
    [Amount] FLOAT NULL, 
    [Completion] INT NULL
)
