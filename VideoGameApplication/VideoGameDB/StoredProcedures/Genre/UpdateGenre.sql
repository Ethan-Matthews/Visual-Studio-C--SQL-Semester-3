create procedure [dbo].[UpdateGenre]
	@genreId int,
	@genreName nvarchar(50)
as
	update Genre set GenreName=@genreName where GenreID=@genreId;
return @@rowcount
