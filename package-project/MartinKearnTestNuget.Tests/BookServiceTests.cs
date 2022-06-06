using MartinKearnTestNuget.Services;

namespace MartinKearnTestNuget.Tests
{
    public class BookServiceTests
    {
        [Fact]
        public void GenerateBookTitleReturnsString()
        {
            // Arrange
            var sut = new BookService();

            // Act
            var result = sut.GenerateBookTitle();

            // Assert
            Assert.NotEmpty(result);
            Assert.Equal(10, result.Length);
        }
    }
}