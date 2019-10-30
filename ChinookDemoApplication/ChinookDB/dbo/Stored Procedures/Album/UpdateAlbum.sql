CREATE PROCEDURE [dbo].[UpdateAlbum]
	@albumId int,
	@artistId int,
	@title nvarchar(160)
AS
	UPDATE Album SET Title = @title, ArtistId = @artistId WHERE AlbumId = @albumId;
RETURN 0