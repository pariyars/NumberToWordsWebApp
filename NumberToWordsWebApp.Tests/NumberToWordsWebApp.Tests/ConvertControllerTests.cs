using Xunit;
using NumberToWordsWebApp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace NumberToWordsWebApp.Tests
{
    public class ConvertControllerTests
    {
        [Fact]
        public void Get_ValidWholeNumber_ReturnsWords()
        {
            // Arrange
            var controller = new ConvertController();

            // Act
            var result = controller.Get("123") as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Contains("HUNDRED", result.Value.ToString().ToUpper());
        }

        [Fact]
        public void Get_InvalidInput_ReturnsBadRequest()
        {
            // Arrange
            var controller = new ConvertController();

            // Act
            var result = controller.Get("abc") as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(400, result.StatusCode);
        }
    }
}
