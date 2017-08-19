using System;

namespace LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Action Hello = () => Console.WriteLine("Hello");
            Hello();

           Predicate<string> Validator = World =>
           {
               return World.Length > 3;
           };

            Console.WriteLine(Validator("Test"));
            Console.ReadKey(true);
        }

       
    }
}