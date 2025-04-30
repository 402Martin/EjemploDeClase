using DataAccess;

namespace DataAccessTests;

[TestClass]
public class MemoryDbTests
{
    [TestMethod]
    public void InitListsTests()
    {
        MemoryDb db = new MemoryDb();
        Assert.AreEqual(db.Movies.Count, 0);
    }
}