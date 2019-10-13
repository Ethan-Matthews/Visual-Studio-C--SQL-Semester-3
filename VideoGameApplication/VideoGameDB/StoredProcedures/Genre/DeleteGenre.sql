create procedure [dbo].[DeleteGenre]
	@genreId int
as
	delete from Genre where GenreID = @genreId; 
return @@rowcount
