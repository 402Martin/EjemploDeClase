using DataAccess;
using Domain;
using Dtos;
using Service;

namespace ServiceTests;

[TestClass]
public class MovieTests
{
    private MovieService _service;
    [TestInitialize]
    public void OnIntalize()
    {
        MemoryDb db = new MemoryDb();
        _service = new MovieService(db);
    }

    [TestMethod]
    public void CreateMovieTest()
    {
 
        CreateMovieDto m = new CreateMovieDto();
        m.Director = "Tomas";
        m.Name = "Martin";
        var result = _service.CreateMovie(m);
        Assert.AreEqual(result.Name, m.Name);
    }
    
    [TestMethod]
    public void GetMovieByNameTest()
    {
        CreateMovieDto m = new CreateMovieDto();
        m.Director = "Tomas";
        m.Name = "Martin";
        _service.CreateMovie(m);
        var result = _service.GetMovieByName("Martin");
        Assert.AreEqual(result.Name, "Martin");
    }
    
    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void GetMovieByNameThrowsArgumentExceptionTest()
    {
        var result = _service.GetMovieByName("Martin");
    }
}
