namespace Domain;

public class Movie
{
    public string Name;
    public string Director;
    public DateTime ReleaseDate = DateTime.Today;
    public Movie(string name, string director, DateTime releaseDate)
    {
        Name = name;
        Director = director;
        ReleaseDate = releaseDate;
    }

}