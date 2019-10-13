create procedure [dbo].[GetGenre]
	@genreID int
as
	select * from Genre where GenreID = @genreID;
return 0
