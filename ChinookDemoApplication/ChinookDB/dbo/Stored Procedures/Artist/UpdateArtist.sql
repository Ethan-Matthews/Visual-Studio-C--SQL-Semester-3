CREATE PROCEDURE [dbo].[UpdateArtist]
	@artistId int,
	@name nvarchar(120)
AS
	UPDATE Artist SET [Name] = @name WHERE ArtistId = @artistId;
RETURN 0