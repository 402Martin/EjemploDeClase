using DataAccess;
using Domain;
using Dtos;

namespace Service;

public class MovieService
{
    private MemoryDb _db;
    public MovieService(MemoryDb db)
    {
        _db = db;
    }
   
    
    public Movie CreateMovie(CreateMovieDto movie)
    {
        Movie movieToAdd = new Movie(movie);
        _db.Movies.Add(movieToAdd);
        return movieToAdd;
    }

    public Movie GetMovieByName(string name)
    {
        var movie =  _db.Movies.Find(movie => movie.Name == name);
        if (movie == null)
        {
            throw new NullReferenceException("Movie not found");
        }

        return movie;
    }
    
    public List<GetMovieDto> GetAll()
    {
        return _db.Movies.Select(movie => movie.ToGetMovieDto()).ToList();
    }
    
    public Movie UpdateMovie(UpdateMovieDto dataIn)
    {
        var movieToUpdate = GetMovieByName(dataIn.OldName);
        movieToUpdate.Name = dataIn.Name;
        movieToUpdate.Director = dataIn.Director;
        return movieToUpdate;
    }
    
    public void Delete(string name)
    {
        var movieToDelete = GetMovieByName(name);
         _db.Movies.Remove(movieToDelete);
    }
}