using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Out.Write("Enter year: ");
            var input = Console.ReadLine();
            PrintIsLeapYear(input);
        }

        public static void PrintIsLeapYear(string input)
        {
            if(!IsLeapYear(int.Parse(input)))
                Console.Out.WriteLine("nay");
            else
                Console.Out.WriteLine("yay");
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
