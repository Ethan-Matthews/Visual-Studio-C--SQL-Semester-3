create procedure [dbo].[InsertDeveloperCountry]
	@developerCountryCode nvarchar(3),
	@developerCountryName nvarchar(50)
as
	insert into DeveloperCountry([CountryCode],         [CountryName])
						 values (@developerCountryCode, @developerCountryName);
return 0;