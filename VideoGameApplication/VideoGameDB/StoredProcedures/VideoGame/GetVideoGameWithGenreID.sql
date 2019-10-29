create procedure [dbo].[GetVideoGameWithGenreID]
	@genreID int
as
	select * from VideoGame where GenreID = @genreID;
return 0
