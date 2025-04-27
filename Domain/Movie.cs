using Dtos;

namespace Domain;

public class Movie
{
    public string Name;
    public string Director;
    public DateTime ReleaseDate = DateTime.Today;
    public Movie(CreateMovieDto dto)
    { 
        Director = dto.Director;
        Name = dto.Name;
    }

    public GetMovieDto ToGetMovieDto()
    {
        return new GetMovieDto()
        {
            Director = Director,
            ReleaseDate = DateOnly.FromDateTime(ReleaseDate.Date),
            Name = Name
        };
    }
}