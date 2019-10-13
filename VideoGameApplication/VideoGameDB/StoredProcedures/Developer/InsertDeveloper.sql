create procedure [dbo].[InsertDeveloper]
	@developerName nvarchar(50),
	@newIdentity int = null output
as
	insert into Developer ([DeveloperName]) values (@developerName);
	set @newIdentity = scope_identity();
return @newIdentity;
