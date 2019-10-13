CREATE PROCEDURE [dbo].[UpdateVideoGame]
	@gameID int,
	@Tile nvarchar(50)
as
	update VideoGame set Title=@Tile where GameID=@gameID;
return @@rowcount
