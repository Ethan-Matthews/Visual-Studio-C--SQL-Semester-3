create procedure [dbo].[InsertDeveloper]
	@developerName nvarchar(50),
	@countryCode nvarchar(3),
	@newIdentity int = null output
as
	insert into Developer ([DeveloperName], [CountryCode])
				   values (@developerName, (select CountryCode
											from DeveloperCountry
											where CountryCode = @countryCode));
	set @newIdentity = scope_identity();
return 0
