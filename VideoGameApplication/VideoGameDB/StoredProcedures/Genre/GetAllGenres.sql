CREATE PROCEDURE [dbo].[GetAllGenres]
	@param1 int = 0,
	@param2 int
AS
	SELECT * from Genre;
RETURN 0
