CREATE PROCEDURE [dbo].[GetAlbumById]
	@albumId int
AS
	SELECT * FROM Album WHERE AlbumId = @albumId;
RETURN 0