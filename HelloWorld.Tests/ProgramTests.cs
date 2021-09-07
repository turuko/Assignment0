using System;
using System.IO;
using Xunit;

namespace HelloWorld.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void PrintIsLeapYear_prints_Nay_If_Not_Leap_Year()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.PrintIsLeapYear("1900");
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("nay", output);
        }

        [Fact]
        public void PrintIsLeapYear_prints_Yay_If_Leap_Year()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.PrintIsLeapYear("2000");
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("yay", output);
        }

        [Fact]
        public void IsLeapYear_true_When_Divisible_By_Four()
        {
            var divisible = 4;

            var resultDivisible = Program.IsLeapYear(divisible);

            Assert.True(resultDivisible);
        }

        [Fact]
        public void IsLeapYear_false_When_Not_Divisible_By_Four()
        {
            var divisible = 5;

            var result = Program.IsLeapYear(divisible);

            Assert.False(result);
        }

        [Fact]
        public void IsLeapYear_false_When_Divisible_By_100()
        {
            var input = 100;

            var result = Program.IsLeapYear(input);

            Assert.False(result);
        }

        [Fact]
        public void IsLeapYear_true_When_Divisible_by_400()
        {
            var input = 400;

            var result = Program.IsLeapYear(input);

            Assert.True(result);
        }
    }
}
