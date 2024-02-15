using PalindromeExercise;
using System;
using Xunit;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("hello", false)]
        [InlineData("", false)]
        [InlineData(null, false)]

        public void Test1(string word, bool expected)
        {

            var w = new WordSmith();
            var actual = w.IsAPalindrome(word);
            Assert.Equal(expected, actual);

        }
    }
}
