CREATE PROCEDURE [dbo].[GetVideoGame]
	@gameID int
as
	select * from VideoGame where GameID = @gameID;
return 0
