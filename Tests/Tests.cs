using MiscLib;
using Xunit;

namespace Tests
{
    public class MiscLibTests
    {
        // Group 1

        /* 1. Method receives the two sides of a Rectangle and return the area
              CalcRectArea(int length, int width) : int
        */

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(3, 4, 12)]
        [InlineData(4, 4, 16)]
        [InlineData(5, -1, -1)]
        public void CalcRectAreaTheory(int value1, int value2, int expected)
        {
            var ml = new GroupOneFunctions();
            var result = ml.CalcRectArea(value1, value2);
            Assert.Equal(result, expected);
        }

        /* 2. Checks if a number is a factorial
              IsFactiorialNum(int num) : bool
        */

        [Theory]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(16, false)]
        [InlineData(120, true)]
        [InlineData(10000, false)]
        [InlineData(3628800, true)]
        [InlineData(-1, false)]
        public void IsFactorialTheory(int value, bool expected)
        {
            var ml = new GroupOneFunctions();
            var result = ml.IsFactiorialNum(value);
            Assert.Equal(result, expected);
        }

        /* 3. Converts a temperature from Celcius to Farenheit, rounded up to the nearest whole number
              CelciusToFarenheit(int celcius) : int
        */

        [Theory]
        [InlineData(0, 32)]
        [InlineData(11, 52)]
        [InlineData(-28, -19)]
        public void CelciusToFarenheitTheory(int value, int expected)
        {
            var ml = new GroupOneFunctions();
            var result = ml.CelciusToFarenheit(value);
            Assert.Equal(result, expected);
        }

        /* 4. Checks a string and returns true if it is palindromic
              IsPalindrome(string word) : bool
        */

        [Theory]
        [InlineData("aba", true)]
        [InlineData("abba", true)]
        [InlineData("abcd", false)]
        [InlineData("abcdedcba", true)]
        [InlineData("aaaa", true)]
        [InlineData("", false)]
        public void IsPalindromeTheory(string value, bool expected)
        {
            var ml = new GroupOneFunctions();
            var result = ml.IsPalindrome(value);
            Assert.Equal(result, expected);
        }

        /* 5. Replaces a character when found in a string
              StringReplace(string word, char replaceChar, char replacement) : string
        */

        [Theory]
        [InlineData("delzczous sandwzch", 'z', 'i', "delicious sandwich")]
        [InlineData("delicious sandwich", 'z', 'i', "delicious sandwich")]
        [InlineData("", 'b', 'a', "")]
        public void StringReplaceTheory(string value1, char value2, char value3, string expected)
        {
            var ml = new GroupOneFunctions();
            var result = ml.StringReplace(value1, value2, value3);
            Assert.Equal(result, expected);
        }

        /* 6. Counts the number of times a character occurs in a string
              CharCount(string word, char countCharacter) : int
        */

        [Theory]
        [InlineData("aaaaa", 'a', 5)]
        [InlineData("unit testing", 'z', 0)]
        public void CharCountTheory(string value1, char value2, int expected)
        {
            var ml = new GroupOneFunctions();
            var result = ml.CharCount(value1, value2);
            Assert.Equal(result, expected);
        }
    }
}
