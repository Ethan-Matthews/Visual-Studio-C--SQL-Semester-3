CREATE TABLE [dbo].[Developer]
(
	[DeveloperID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DeveloperName] NVARCHAR(50) NOT NULL, 
    [CountryCode] NVARCHAR(3) NOT NULL, 
    CONSTRAINT [FK_Developer_DeveloperCountry] FOREIGN KEY ([CountryCode]) REFERENCES [DeveloperCountry]([CountryCode])
)
