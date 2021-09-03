using System;
using System.IO;
using Xunit;

namespace HelloWorld.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_prints_Hello_World()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Hello World!", output);
        }

        [Fact]
        public void IsLeapYear_checks_Divisible_By_Four()
        {
            var notDivisible = 5;
            var divisible = 4;

            var resultNotDivisible = Program.IsLeapYear(notDivisible);
            var resultDivisible = Program.IsLeapYear(divisible);

            Assert.False(resultNotDivisible);
            Assert.True(resultDivisible);
        }
    }
}
