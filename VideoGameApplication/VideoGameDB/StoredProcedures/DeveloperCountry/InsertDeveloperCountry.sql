create procedure [dbo].[InsertDeveloperCountry]
	@developerCountryName nvarchar(50),
	@developerCountryCode nvarchar(3) = null output
as
	insert into DeveloperCountry([CountryName], [CountryCode]) values (@developerCountryName, @developerCountryCode);
return @developerCountryCode;
