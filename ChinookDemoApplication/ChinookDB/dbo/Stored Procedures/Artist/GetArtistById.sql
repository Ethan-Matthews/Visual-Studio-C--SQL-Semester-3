CREATE PROCEDURE [dbo].[GetArtistById]
	@artistId int
AS
	SELECT * FROM Artist WHERE ArtistId = @artistId;
RETURN 0
