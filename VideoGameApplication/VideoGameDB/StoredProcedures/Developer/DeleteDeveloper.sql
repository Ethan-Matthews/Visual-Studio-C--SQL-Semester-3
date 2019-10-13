create procedure [dbo].[DeleteDeveloper]
	@developerID int
as
	delete from Developer where DeveloperID = @developerID; 
return @@rowcount
