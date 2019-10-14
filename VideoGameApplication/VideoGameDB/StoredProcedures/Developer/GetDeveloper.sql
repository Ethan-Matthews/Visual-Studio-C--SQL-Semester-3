create procedure [dbo].[GetDeveloper]
	@developerID int
as
	select * from Developer where DeveloperID = @developerID;
return 0
