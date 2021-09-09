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

            Program.PrintIsLeapYear(1900);
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("nay", output);
        }

        [Fact]
        public void PrintIsLeapYear_prints_Yay_If_Leap_Year()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.PrintIsLeapYear(2000);
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("yay", output);
        }

        [Fact]
        public void ValidateInput_prints_Error_If_Input_Not_Number()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            var year = 0;

            Program.ValidateInput("Hello", out year);
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Please enter a year after 1582", output);
        }

        [Fact]
        public void ValidateInput_prints_Error_If_Input_Before_1582()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            var year = 0;

            Program.ValidateInput("1581", out year);
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Please enter a year after 1582", output);
        }

        [Fact]
        public void ValidateInput_False_If_Input_Not_Number()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            var year = 0;

            var result = Program.ValidateInput("Hello", out year);

            Assert.False(result);
            Assert.Equal(0,year);
        }

        [Fact]
        public void ValidateInput_False_If_Input_Before_1582()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            var year = 0;

            var result = Program.ValidateInput("1581", out year);

            Assert.False(result);
            Assert.Equal(1581,year);
        }

        [Fact]
        public void ValidateInput_True_If_Input_Correct()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            var year = 0;

            var result = Program.ValidateInput("1582", out year);

            Assert.True(result);
            Assert.Equal(1582,year);
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
