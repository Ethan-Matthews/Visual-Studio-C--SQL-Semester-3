CREATE PROCEDURE [dbo].[UpdateGenre]
	@genreId int,
	@name nvarchar(120)
AS
	UPDATE Genre SET [Name] = @name WHERE GenreId = @genreId;
RETURN 0
