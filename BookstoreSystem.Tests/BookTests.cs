using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookstoreSystem.Models;

namespace BookstoreSystem.Tests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void GetInfo_ReturnsCorrectInfo()
        {
            // Arrange
            var book = new Book("The Great Gatsby", "F. Scott Fitzgerald");

            // Act
            var result = book.GetInfo();

            // Assert
            Assert.AreEqual("Book: The Great Gatsby by F. Scott Fitzgerald", result);
        }
    }
}