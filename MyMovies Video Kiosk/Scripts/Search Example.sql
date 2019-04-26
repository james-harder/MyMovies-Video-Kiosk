DECLARE @SearchTerm varchar(50)
SET @SearchTerm = 't'


SELECT        Movie.MovieID, Movie.Title, Director.LastName, Movie.ReleaseDate, Movie.Price
FROM            Movie INNER JOIN
                         Director ON Movie.DirectorID = Director.DirectorID
WHERE        Movie.Title LIKE CONCAT('%', @SearchTerm, '%')

GO