namespace BookstoreSystem.Tests;

[TestClass]
public class EbookTests
{
    [TestMethod]
    public void TestPolymorphism()
    {
        // Arrange
        Book[] books = {
            new Book { Title = "Generic Book", Author = "John Smith" },
            new Magazine { Title = "Tech Weekly", IssueNumber = 12 },
            new Ebook { Title = "Learn C#", FileSize = "5MB" }
        };

        Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
        Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
        Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetInfo());
    }
}
}
