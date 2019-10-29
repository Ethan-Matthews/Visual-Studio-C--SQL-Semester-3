create procedure [dbo].[GetDevelopersWithCountryCode]
	@countryCode varchar(3)
as
	select * from Developer where CountryCode = @countryCode;
return 0
