using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookstoreSystem.Models;

namespace BookstoreSystem.Tests
{
    [TestClass]
    public class TextbookTests
    {
        [TestMethod]
        public void GetInfo_ReturnsCorrectInfo()
        {
            // Arrange
            var textbook = new Textbook("Introduction to Algorithms", "Thomas H. Cormen", "Computer Science");

            // Act
            var result = textbook.GetInfo();

            // Assert
            Assert.AreEqual("Textbook: Introduction to Algorithms by Thomas H. Cormen (Subject: Computer Science)", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_ThrowsException_WhenSubjectIsEmpty()
        {
            // Arrange & Act
            var textbook = new Textbook("Invalid Textbook", "Author", "");

            // Assert is handled by ExpectedException
        }
    }
}