namespace BookstoreTest
{
    [TestClass]
    public class PolymorphismTests
    {
        [TestMethod]
        public void TestPolymorphism_GetInfo_Method()
        {
            Book[] books = new Book[]
            {
        new Book { Title = "Generic Book", Author = "John Smith" },
        new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 },
        new Ebook { Title = "Learn C#", Author = "Mark Jones", FileSizeMB = 5 },
        new Textbook { Title = "Mathematics Fundamentals I & II", Author = "James T.", Subject = "Algebra" }
            };

            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly - Issue 12 - by Jane Doe", books[1].GetInfo());
            Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetInfo());
            Assert.AreEqual("Mathematics Fundamentals I & II on Subject 'Algebra'", books[3].GetInfo());
        }
        [TestMethod]
        public void CreateBook_EmptyTitle_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                new Book { Title = "", Author = "John Doe" };
            });
        }

        [TestMethod]
        public void CreateTextbook_EmptySubject_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                new Textbook { Title = "Valid Title", Author = "John Doe", Subject = "" };
            });
        }

        [TestMethod]
        public void CreateMagazine_NegativeIssueNumber_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                new Magazine { Title = "Valid Title", Author = "Jane Doe", IssueNumber = -1 };
            });
        }
    }
}
