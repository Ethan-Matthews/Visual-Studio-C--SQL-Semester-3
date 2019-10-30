CREATE PROCEDURE [dbo].[AddAlbum]
	@title nvarchar(160),
	@artistId int,
	@newId int OUTPUT
AS
	INSERT INTO Album ([Title], ArtistId) VALUES (@title, @artistId);
	SET @newId = SCOPE_IDENTITY();
RETURN 0
