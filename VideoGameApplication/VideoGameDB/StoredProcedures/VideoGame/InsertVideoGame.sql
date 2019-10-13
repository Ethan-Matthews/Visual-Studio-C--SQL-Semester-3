CREATE PROCEDURE [dbo].[InsertVideoGame]
	@newIdentity int = null output,
	@title nvarchar(50),
	@releaseDate Date,
	@numberOfAchievements int,
	@developerID int,
	@genreID int
as
	insert into VideoGame([Title],[ReleaseDate],[NumberOfAchievements],[DeveloperID],[GenreID])
				  values (@title, @releaseDate, @numberOfAchievements, @developerID, @genreID);
	set @newIdentity = scope_identity();
return @newIdentity;
