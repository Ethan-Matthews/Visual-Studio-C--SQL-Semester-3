CREATE PROCEDURE [dbo].[DeleteArtist]
	@artistId int
AS
	DELETE FROM Artist WHERE ArtistId = @artistId;
RETURN 0

