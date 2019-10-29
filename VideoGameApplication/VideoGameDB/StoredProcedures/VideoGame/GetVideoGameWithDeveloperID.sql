create procedure [dbo].[GetVideoGameWithDeveloperID]
	@developerID int
as
	select * from VideoGame where DeveloperID = @developerID;
return 0
