using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace RegExDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your Phone Number {<Country Code>-<Phone Number>}: ");
            string input = ReadLine();

            Regex phoneChecker = new Regex(@"(\(+)?)?([0-9].-[0-9]");

            //^ (\(?\+?[0 - 9] *\)?)?[0-9_\- \(\)]*$
            
            if (phoneChecker.IsMatch(input))
            {
                WriteLine("Thank you!");
            }
            else
            {
                WriteLine($"This is not a Phone Number: {input}");
            }

            ReadKey(true);
        }
    }
}