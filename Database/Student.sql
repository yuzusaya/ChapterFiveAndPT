CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(100) NULL, 
    [GenderId] INT NULL, 
    CONSTRAINT [FK_Student_ToGender] FOREIGN KEY ([GenderId]) REFERENCES [Gender]([Id])
)
