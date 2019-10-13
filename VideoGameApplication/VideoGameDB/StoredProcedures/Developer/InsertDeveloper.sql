create procedure [dbo].[InsertDeveloper]
	@newIdentity int = null output,
	@developerName nvarchar(50),
	@countryCode nvarchar(3)
as
	insert into Developer ([DeveloperName], [CountryCode])
				   values (@developerName, (select CountryCode
											from DeveloperCountry
											where CountryCode = @countryCode));
	set @newIdentity = scope_identity();
return 0
