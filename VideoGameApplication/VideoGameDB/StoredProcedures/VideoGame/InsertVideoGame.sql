create procedure [dbo].[InsertVideoGame]
	@newIdentity int = null output,
	@title nvarchar(50),
	@releaseDate Date,
	@totalHoursPlayed int,
	@numberOfAchievements int,
	@developerID int,
	@genreID int
as
	insert into VideoGame([Title],[ReleaseDate],[TotalHoursPlayed],[NumberOfAchievements],[DeveloperID],[GenreID])
				  values (@title, @releaseDate, @totalHoursPlayed, @numberOfAchievements,
						 (Select DeveloperID from Developer where DeveloperID = @developerID),
						 (Select GenreID from Genre where GenreID = @genreID));
	set @newIdentity = scope_identity();
return @newIdentity;
