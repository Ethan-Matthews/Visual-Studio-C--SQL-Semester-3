CREATE PROCEDURE [dbo].[GetGenreById]
	@genreId int
AS
	SELECT * FROM Genre WHERE GenreId = @genreId;
RETURN 0
