create procedure [dbo].[UpdateDeveloperCountry]
	@developerCountryCode nvarchar(3),
	@developerCountryName nvarchar(50)
as
	update DeveloperCountry set CountryName=@developerCountryName where CountryCode=@developerCountryCode;
return @@rowcount