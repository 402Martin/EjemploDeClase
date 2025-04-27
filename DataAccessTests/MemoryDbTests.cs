using DataAccess;

namespace DataAccessTests;

[TestClass]
public class MemoryDbTests
{
    [TestMethod]
    public void InitListsTests()
    {
        MemoryDb db = new MemoryDb();
        Assert.Equals(db.Movies.Count, 0);
    }
}