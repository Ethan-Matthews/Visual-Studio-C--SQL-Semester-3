CREATE PROCEDURE [dbo].[GetDeveloperCountry]
	@DeveloperCountryCode nvarchar(3)
as
	select * from DeveloperCountry where CountryCode = @DeveloperCountryCode;
return 0
