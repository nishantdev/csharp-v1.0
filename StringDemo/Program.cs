using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Jones, Alan";

            string fName = Name.Split(',')[0];
            string lName = Name.Split(',')[1].Trim();

            Console.WriteLine($"Hello {fName} {lName}");

            Console.ReadKey(true);

        }
    }
}