using System;
using static System.Console;

namespace ArgumentsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the argument values to the following: red yellow 50 10

            ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[0], true);

            BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[1], true);

            WindowWidth = int.Parse(args[2]);

            WindowHeight = int.Parse(args[3]);

            WriteLine($"There are {args.Length} arguments.");

            foreach (var arg in args)
            {
                WriteLine(arg);
            }

            ReadKey(true);
        }
    }
}