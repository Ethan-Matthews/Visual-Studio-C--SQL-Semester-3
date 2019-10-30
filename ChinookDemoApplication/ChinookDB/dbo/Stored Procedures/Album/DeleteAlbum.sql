CREATE PROCEDURE [dbo].[DeleteAlbum]
	@albumId int
AS
	DELETE FROM Album WHERE AlbumId = @albumId;
RETURN 0