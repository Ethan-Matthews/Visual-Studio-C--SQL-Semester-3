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

If not exists (select 1 from Developer)
Begin
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Little Green Men', 'HRV'); -- X4 sim - StarPoint Warlords.
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Projekt CD', 'POL'); -- ARPG - Witcher3.
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Ubisoft Blue Byte', 'DEU'); -- City builder - Anno 2205.
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Larian Studios', 'BEL'); -- Dungeon Crawler - Divinity OS2.
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Namco', 'JPN'); -- Fighting - Soul Calibur.
	Insert into Developer ([DeveloperName], [CountryCode]) values ('ID Software', 'USA'); -- FPS - DOOM.
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Ironclad Games', 'CAN'); -- RTS - SSER.
	Insert into Developer ([DeveloperName], [CountryCode]) values ('THQ Nordic', 'AUT'); -- RPG - SpellForce3.
	Insert into Developer ([DeveloperName], [CountryCode]) values ('Creative Assembly', 'GBR'); -- TBS - ROME2: TW.
end


