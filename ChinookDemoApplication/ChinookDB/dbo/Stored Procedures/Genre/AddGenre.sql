CREATE PROCEDURE [dbo].[AddGenre]
	@name nvarchar(120),
	@newId int OUTPUT
AS
	INSERT INTO Genre ([Name]) VALUES (@name);
	SET @newId = SCOPE_IDENTITY();
RETURN 0
