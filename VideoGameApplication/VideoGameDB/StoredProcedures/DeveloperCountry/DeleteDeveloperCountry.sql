create procedure [dbo].[DeleteDeveloperCountry]
	@countryCode nvarchar(3)
as
	delete from DeveloperCountry
		  where CountryCode = @countryCode
return @@rowcount