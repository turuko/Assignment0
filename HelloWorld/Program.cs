using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Out.Write("Enter year: ");
            var input = Console.ReadLine();
            while(!PrintIsLeapYear(input))
            {
                Console.Out.Write("Enter year: ");
                input = Console.ReadLine();
            }
        }

        public static bool PrintIsLeapYear(string input)
        {
            int year = 0;

            if(int.TryParse(input, out year) && year >= 1582)
            {
                if(!IsLeapYear(year))
                {
                    Console.Out.WriteLine("nay");
                    return true;
                }
                else
                {
                    Console.Out.WriteLine("yay");
                    return true;
                }
            }
            else
            {
                Console.Out.WriteLine("Please enter a year after 1582\n");
                return false;
            }

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
