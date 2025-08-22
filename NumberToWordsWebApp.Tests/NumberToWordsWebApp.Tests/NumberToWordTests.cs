using Xunit;
using NumberToWordsWebApp;

namespace NumberToWordsWebApp.Tests
{
    public class NumberToWordTests
    {
        [Theory]
        [InlineData(123.45, "ONE HUNDRED TWENTY THREE DOLLARS AND FORTY FIVE CENTS")]
        [InlineData(0.99, "NINETY NINE CENTS")]
        [InlineData(1001, "ONE THOUSAND ONE DOLLARS")]
        [InlineData(0, "ZERO DOLLARS")]
        [InlineData(1000000, "ONE MILLION DOLLARS")]
        [InlineData(19.19, "NINETEEN DOLLARS AND NINETEEN CENTS")]
        [InlineData(20.05, "TWENTY DOLLARS AND FIVE CENTS")]
        public void ToWords_ReturnsCorrectWords(decimal input, string expected)
        {
            // Act
            string result = input.ToWords();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
