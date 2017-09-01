using System;
using static System.Console;

namespace Ch05_Debugging
{
    class Program
    {
        static double Add(double a, double b)
        {

            return a * b;

        }

        static void Main(string[] args)
        {
            double a = 10.50;
            double b = 20.50;

            var c = Add(a, b);

            WriteLine($"{a} + {b} = {c}");

            ReadKey(true);
        }
    }
}