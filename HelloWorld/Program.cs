using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsLeapYear(int year)
        {
            if(year % 4 == 0)
                return true;
            else
                return false;
        }
    }
}
