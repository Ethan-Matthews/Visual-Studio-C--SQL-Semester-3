create procedure [dbo].[GetAllGenres]
as
	select * from Genre
	order by GenreName;
return 0
