using System;
using System.Collections.Generic;
using static System.Console;

namespace Ch04_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string>();

            cities.Add("Chennai");
            cities.Add("New Delhi");
            cities.Add("Kolkata");
            cities.Add("Mumbai");

            WriteLine("Initial List :");

            foreach (var city in cities)
            {
                WriteLine($"\t\t{city}");
            }

            WriteLine($"First City: {cities[0]}");
            WriteLine($"Last City: {cities[cities.Count - 1]}");

            cities.Insert(0, "Hyderabad");
            cities.Insert(1, "Bangalore");
            cities.Add("Patna");

            WriteLine("New List :");

            foreach (var city in cities)
            {
                WriteLine($"\t\t{city}");
            }

            WriteLine($"First City: {cities[0]}");
            WriteLine($"Last City: {cities[cities.Count - 1]}");

            cities.Remove("Patna");
            cities.RemoveAt(0);

            WriteLine("After Removing:");

            foreach (var city in cities)
            {
                WriteLine($"\t\t{city}");
            }

            ReadKey(true);
        }
    }
}