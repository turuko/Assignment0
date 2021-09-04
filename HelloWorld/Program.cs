using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter year: ");
            var input = Console.ReadLine();
            var result = IsLeapYear(int.Parse(input));

            if(result)
                Console.WriteLine(input + " is a leap year!");
            else
                Console.WriteLine(input + " is not a leap year!");
        }

        public static bool IsLeapYear(int year)
        {
            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                        return true;
                    else
                        return false;
                }
                return true;
            }
            else
                return false;
        }
    }
}
