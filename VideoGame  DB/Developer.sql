CREATE TABLE [dbo].[Developer]
(
	[DeveloperID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DeveloperName] NVARCHAR(50) NULL, 
    [CountryCode] NVARCHAR(3) NULL, 
    CONSTRAINT [FK_Developer_DeveloperCountry] FOREIGN KEY ([CountryCode]) REFERENCES [DeveloperCountry]([CountryCode])
)
