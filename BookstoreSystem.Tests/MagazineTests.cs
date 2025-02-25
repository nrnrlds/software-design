using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookstoreSystem.Models;

namespace BookstoreSystem.Tests
{
    [TestClass]
    public class MagazineTests
    {
        [TestMethod]
        public void GetInfo_ReturnsCorrectInfo()
        {
            // Arrange
            var magazine = new Magazine("National Geographic", "Various", 123);

            // Act
            var result = magazine.GetInfo();

            // Assert
            Assert.AreEqual("Magazine: National Geographic, Issue #123 by Various", result);
        }
    }
}
