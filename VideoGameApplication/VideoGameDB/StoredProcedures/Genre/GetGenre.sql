create procedure [dbo].[GetCategory]
	@genreId int
as
	select * from Genre where GenreID = @genreId;
return 0
