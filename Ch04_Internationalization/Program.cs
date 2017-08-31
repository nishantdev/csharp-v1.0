using System;
using System.Globalization;
using static System.Console;

namespace Ch04_Internationalization
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo global = CultureInfo.CurrentCulture;
            CultureInfo local = CultureInfo.CurrentUICulture;

            WriteLine($"Global Culture: {global.Name} {global.DisplayName}");
            WriteLine($"Local Culture: {local.Name} {local.DisplayName}");


            ReadKey(true);

        }
    }
}