CREATE TABLE [dbo].[VideoGame]
(
	[GameID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [ReleaseDate] DATE NOT NULL, 
    [TotalHoursPlayed] INT NOT NULL, 
	[NumberOfAchievements] INT NULL,
    [DeveloperID] INT NOT NULL, 
    [GenreID] INT NOT NULL, 
    CONSTRAINT [FK_VideoGame_ToDeveloper] FOREIGN KEY ([DeveloperID]) REFERENCES [Developer]([DeveloperID]), 
    CONSTRAINT [FK_VideoGame_ToGenre] FOREIGN KEY ([GenreID]) REFERENCES [Genre]([GenreID]) 
)
