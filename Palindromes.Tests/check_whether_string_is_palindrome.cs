using System;
using Xunit;

namespace Palindromes.Tests
{
    public class check_whether_string_is_palindrome
    {
        [Fact]
        public void stats_is_a_palindrome()
        {
            // Arrange
            var inputString = "Stats";
            PalindromeChecker palindromeChecker = new PalindromeChecker();

            // Act
            var actualResult = palindromeChecker.Check(inputString);

            // Assert
            Assert.True(actualResult);
        }
    }
}
