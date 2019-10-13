create procedure [dbo].[UpdateDeveloper]
	@developerID int,
	@developerName nvarchar(50)
as
	update Developer set DeveloperName=@developerName where DeveloperID=@developerID;
return @@rowcount
