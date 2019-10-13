create procedure [dbo].[InsertDeveloper]
	@newIdentity int = null output,
	@developerName nvarchar(50),
	@countryCode nvarchar(3)
	
as
	insert into Developer ([DeveloperName], [CountryCode]) values (@developerName, @countryCode);
	set @newIdentity = scope_identity();
return @newIdentity;
