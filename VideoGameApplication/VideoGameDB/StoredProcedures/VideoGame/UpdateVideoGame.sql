CREATE PROCEDURE [dbo].[UpdateVideoGame]
	@gameID int,
	@title nvarchar(50),
	@releaseDate Date,
	@totalHoursPlayed int,
	@numberOfAchievements int,
	@developerID int,
	@genreID int


as
	update VideoGame set Title=@title,
						 ReleaseDate = @releaseDate,
						 TotalHoursPlayed = @totalHoursPlayed,
						 NumberOfAchievements = @numberOfAchievements,
						 DeveloperID = (Select DeveloperID from Developer where DeveloperID = @developerID),
						 GenreID = (Select GenreID from Genre where GenreID = @genreID)
					 where GameID=@gameID;
return @@rowcount
