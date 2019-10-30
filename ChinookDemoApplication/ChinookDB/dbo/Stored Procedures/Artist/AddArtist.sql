CREATE PROCEDURE [dbo].[AddArtist]
	@name nvarchar(120),
	@newId int OUTPUT
AS
	INSERT INTO Artist ([Name]) VALUES (@name);
	SET @newId = SCOPE_IDENTITY();
RETURN 0
