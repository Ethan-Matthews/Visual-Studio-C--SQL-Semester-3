create procedure [dbo].[UpdateDeveloper]
	@developerID int,
	@developerName nvarchar(50),
	@countryCode nvarchar(3)
as
	update Developer 
		set DeveloperName = @developerName,
			CountryCode = @countryCode
		where DeveloperID = @developerID;
return @@rowcount
