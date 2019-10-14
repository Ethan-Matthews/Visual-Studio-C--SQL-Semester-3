/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

--Popuate Genre.

DBCC CHECKIDENT (Genre, RESEED, 1)

If not exists (select 1 from Genre)
Begin
	Insert into Genre ([GenreName]) values ('4X Simulator');
	Insert into Genre ([GenreName]) values ('Action Role Playing');
	Insert into Genre ([GenreName]) values ('City Builder');
	Insert into Genre ([GenreName]) values ('Dungeon Crawler');
	Insert into Genre ([GenreName]) values ('Fighting');
	Insert into Genre ([GenreName]) values ('First Person Shooter');
	Insert into Genre ([GenreName]) values ('Real Time Srategy');
	Insert into Genre ([GenreName]) values ('Role Playing');
	Insert into Genre ([GenreName]) values ('Turn Based Strategy');
end

--Populate Developer Country.

If not exists (select 1 from DeveloperCountry)
Begin
	Insert into DeveloperCountry ([CountryCode], [CountryName]) values ('CAN', 'Canada');
	Insert into DeveloperCountry ([CountryCode], [CountryName]) values ('USA', 'United States');
	Insert into DeveloperCountry ([CountryCode], [CountryName]) values ('DEU', 'Germany');
	Insert into DeveloperCountry ([CountryCode], [CountryName]) values ('BEL', 'Belgium');
	Insert into DeveloperCountry ([CountryCode], [CountryName]) values ('JPN', 'Japan');
	Insert into DeveloperCountry ([CountryCode], [CountryName]) values ('POL', 'Poland');
	Insert into DeveloperCountry ([CountryCode], [CountryName]) values ('HRV', 'Croatia');
	Insert into DeveloperCountry ([CountryCode], [CountryName]) values ('GBR', 'United Kingdom');
	Insert into DeveloperCountry ([CountryCode], [CountryName]) values ('AUT', 'Austria');
end

--Populate Developer.

DBCC CHECKIDENT (Developer, RESEED, 1)

If not exists (select 1 from Developer)
Begin
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Little Green Men', 'HRV');
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Projekt CD', 'POL');
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Ubisoft Blue Byte', 'DEU');
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Larian Studios', 'BEL');
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Namco', 'JPN');
	Insert into Developer ([DeveloperName], [CountryCode]) values ('ID Software', 'USA');
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Ironclad Games', 'CAN');
	Insert into Developer ([DeveloperName], [CountryCode]) values ('THQ Nordic', 'AUT');
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Creative Assembly', 'GBR');
end

--Populate VideoGame.

DBCC CHECKIDENT (VideoGame, RESEED, 1)

If not exists (select 1 from VideoGame)
Begin
	Insert into VideoGame ([Title], [ReleaseDate], [TotalHoursPlayed], [NumberOfAchievements], [DeveloperID], [GenreID])
				   values ('StarPoint Warloads', 'May 23, 2017', 59, 54,
					      (Select DeveloperID from Developer where DeveloperName = 'Little Green Men'),
					      (Select GenreID from Genre where GenreName = '4X Simulator'));

	Insert into VideoGame ([Title], [ReleaseDate], [TotalHoursPlayed], [NumberOfAchievements], [DeveloperID], [GenreID])
				   values ('Witcher 3', 'May 19, 2015', 133, 78,
					      (Select DeveloperID from Developer where DeveloperName = 'Projekt CD'),
					      (Select GenreID from Genre where GenreName = 'Action Role Playing'));

	Insert into VideoGame ([Title], [ReleaseDate], [TotalHoursPlayed], [NumberOfAchievements], [DeveloperID], [GenreID])
				   values ('Anno 2205', 'November 3, 2015', 24, 198,
					      (Select DeveloperID from Developer where DeveloperName = 'Ubisoft Blue Byte'),
					      (Select GenreID from Genre where GenreName = 'City Builder'));

	Insert into VideoGame ([Title], [ReleaseDate], [TotalHoursPlayed], [NumberOfAchievements], [DeveloperID], [GenreID])
				   values ('Divinity OS2', 'September 14, 2017', 196, 97,
					      (Select DeveloperID from Developer where DeveloperName = 'Larian Studios'),
					      (Select GenreID from Genre where GenreName = 'Dungeon Crawler'));

	Insert into VideoGame ([Title], [ReleaseDate], [TotalHoursPlayed], [NumberOfAchievements], [DeveloperID], [GenreID])
				   values ('Soul Calibur VI', 'October 19, 2018', 43, 49,
					      (Select DeveloperID from Developer where DeveloperName = 'Namco'),
					      (Select GenreID from Genre where GenreName = 'Fighting'));

	Insert into VideoGame ([Title], [ReleaseDate], [TotalHoursPlayed], [NumberOfAchievements], [DeveloperID], [GenreID])
				   values ('DOOM', 'May 13, 2016', 23, 54,
					      (Select DeveloperID from Developer where DeveloperName = 'ID Software'),
					      (Select GenreID from Genre where GenreName = 'First Person Shooter'));

	Insert into VideoGame ([Title], [ReleaseDate], [TotalHoursPlayed], [NumberOfAchievements], [DeveloperID], [GenreID])
				   values ('Sins of a Solar Empire', 'February 4, 2008', 243, 68,
					      (Select DeveloperID from Developer where DeveloperName = 'Ironclad Games'),
					      (Select GenreID from Genre where GenreName = 'Real Time Srategy'));

	Insert into VideoGame ([Title], [ReleaseDate], [TotalHoursPlayed], [NumberOfAchievements], [DeveloperID], [GenreID])
				   values ('SpellForce3', 'December 7, 2017', 39, 39,
					      (Select DeveloperID from Developer where DeveloperName = 'THQ Nordic'),
					      (Select GenreID from Genre where GenreName = 'Role Playing'));

	Insert into VideoGame ([Title], [ReleaseDate], [TotalHoursPlayed], [NumberOfAchievements], [DeveloperID], [GenreID])
				   values ('Total War Rome 2', 'September 3, 2013', 198, 188,
					      (Select DeveloperID from Developer where DeveloperName = 'Creative Assembly'),
					      (Select GenreID from Genre where GenreName = 'Turn Based Strategy'));
end
