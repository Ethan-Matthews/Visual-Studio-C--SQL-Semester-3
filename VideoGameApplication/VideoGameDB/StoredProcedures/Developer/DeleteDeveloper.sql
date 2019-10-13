create procedure [dbo].[DeleteDeveloper]
	@developerID int
as
	delete from DeveloperCountry where CountryCode = @developerID; 
return @@rowcount
