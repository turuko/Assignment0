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
        public void PrintIsLeapYear_prints_Error_If_Input_Not_Number()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.PrintIsLeapYear("Hello");
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Please enter a year after 1582", output);
        }

        [Fact]
        public void PrintIsLeapYear_prints_Error_If_Input_Before_1582()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.PrintIsLeapYear("1581");
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Please enter a year after 1582", output);
        }

        [Fact]
        public void IsLeapYear_true_When_Divisible_By_Four()
        {
            var divisible = 2004;

            var resultDivisible = Program.IsLeapYear(divisible);

            Assert.True(resultDivisible);
        }

        [Fact]
        public void IsLeapYear_false_When_Not_Divisible_By_Four()
        {
            var divisible = 2005;

            var result = Program.IsLeapYear(divisible);

            Assert.False(result);
        }

        [Fact]
        public void IsLeapYear_false_When_Divisible_By_100()
        {
            var input = 1900;

            var result = Program.IsLeapYear(input);

            Assert.False(result);
        }

        [Fact]
        public void IsLeapYear_true_When_Divisible_by_400()
        {
            var input = 2000;

            var result = Program.IsLeapYear(input);

            Assert.True(result);
        }
    }
}
