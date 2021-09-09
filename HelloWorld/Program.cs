using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Out.Write("Enter year: ");
            var input = Console.ReadLine();
            int year;
            while(!ValidateInput(input, out year))
            {
                Console.Out.Write("Enter year: ");
                input = Console.ReadLine();
            }
            PrintIsLeapYear(year);
        }

        public static bool ValidateInput(string input, out int year)
        {
            if(int.TryParse(input, out year) && year >= 1582)
                return true;

            else
                Console.Out.WriteLine("Please enter a year after 1582\n");
                return false;
        }

        public static void PrintIsLeapYear(int year)
        {
            if(!IsLeapYear(year))
            {
                Console.Out.WriteLine("nay");
            }
            else
            {
                Console.Out.WriteLine("yay");
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
