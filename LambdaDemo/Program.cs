using System;

namespace LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Action Hello = () => Console.WriteLine("Hello");
            Hello();
            Console.ReadKey(true);
        }
    }
}