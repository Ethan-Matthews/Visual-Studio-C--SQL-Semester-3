create procedure [dbo].[InsertGenre]
	@genreName nvarchar(50),
	@newIdentity int = null output
as
	insert into Genre ([GenreName]) values (@genreName);
	set @newIdentity = scope_identity();
return @newIdentity;
