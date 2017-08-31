using System;
using System.Collections.Generic;
using static System.Console;

namespace Ch04_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            var KeyWords = new Dictionary<string, string>();

            KeyWords.Add("int", "32-bit integer data type");
            KeyWords.Add("long", "64-bit integer data type");
            KeyWords.Add("float", "Single precision floating point number");

            foreach(KeyValuePair<string,string> item in KeyWords)
            {
                WriteLine($"Data Type: {item.Key}, Description: {item.Value}");

            }

            ReadKey(true);
        }
    }
}