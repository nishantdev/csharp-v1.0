using System;

namespace CheckedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.MaxValue;
            Console.WriteLine(i);

            checked
            {
                try
                {
                    Console.WriteLine(i/0);
                }
                catch(System.DivideByZeroException)
                {
                    Console.WriteLine("Divide by 0");
                }
            }

            float f = 1;

            f = f / 0;

            f = f * 0;

            if(float.IsInfinity(f))
            {
                Console.WriteLine("Infinity");
            }
            else
            {

                Console.WriteLine(f);
            }

            
            unchecked
            {
                int j = int.MaxValue + 1;

                Console.WriteLine(j);
            }
                
            
            
            Console.ReadKey(true);
        }
    }
}