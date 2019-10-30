CREATE PROCEDURE [dbo].[DeleteGenre]
	@genreId int
AS
	DELETE FROM Genre WHERE GenreId = @genreId;
RETURN 0
