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

        [Fact]
        public void amore_roma_is_a_palindrome()
        {
            // Arrange
            var inputString = "Amore, Roma";
            PalindromeChecker palindromeChecker = new PalindromeChecker();

            // Act
            var actualResult = palindromeChecker.Check(inputString);

            // Assert
            Assert.True(actualResult);
        }

        [Fact]
        public void no_x_in_nixon_is_a_palindrome()
        {
            // Arrange
            var inputString = "No 'x' in Nixon";
            PalindromeChecker palindromeChecker = new PalindromeChecker();

            // Act
            var actualResult = palindromeChecker.Check(inputString);

            // Assert
            Assert.True(actualResult);
        }

        [Fact]
        public void was_it_a_cat_i_saw_is_a_palindrome()
        {
            // Arrange
            var inputString = "Was it a cat I saw?";
            PalindromeChecker palindromeChecker = new PalindromeChecker();

            // Act
            var actualResult = palindromeChecker.Check(inputString);

            // Assert
            Assert.True(actualResult);
        }

        [Fact]
        public void stars_is_not_a_palindrome()
        {
            // Arrange
            var inputString = "Stars";
            PalindromeChecker palindromeChecker = new PalindromeChecker();

            // Act
            var actualResult = palindromeChecker.Check(inputString);

            // Assert
            Assert.False(actualResult);
        }

        [Fact]
        public void palindrome_is_not_a_palindrome()
        {
            // Arrange
            var inputString = "palindrome";
            PalindromeChecker palindromeChecker = new PalindromeChecker();

            // Act
            var actualResult = palindromeChecker.Check(inputString);

            // Assert
            Assert.False(actualResult);
        }

        [Fact]
        public void o_a_kak_Uwakov_lil_vo_kawu_kakao_is_a_palindrome()
        {
            // Arrange
            var inputString = "O, a kak Uwakov lil vo kawu kakao!";
            PalindromeChecker palindromeChecker = new PalindromeChecker();

            // Act
            var actualResult = palindromeChecker.Check(inputString);

            // Assert
            Assert.True(actualResult);
        }
    }
}
