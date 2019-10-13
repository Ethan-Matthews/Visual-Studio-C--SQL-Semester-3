create procedure [dbo].[DeleteDeveloperCountry]
	@developerCountryCode nvarchar(3)
as
	delete from DeveloperCountry where CountryCode = @DeveloperCountryCode; 
return @@rowcount
