using System;

namespace SortCities
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[10];

            Console.WriteLine("=== City Name Sorter ===");
            Console.WriteLine("Enter names of 10 cities:");

            for (int i = 0; i < 10; i++)
            {
                cities[i] = Console.ReadLine();
            }

            // Sort array using Array.Sort()
            Array.Sort(cities);
            Console.WriteLine("\n--- Cities in Sorted Order ---");

            foreach (string i in cities)
            {
                Console.WriteLine(i);
            }
        }
    }
}
