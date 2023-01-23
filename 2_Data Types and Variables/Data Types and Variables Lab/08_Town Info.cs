using System;

namespace Data_Types_and_Variables_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            string area = Console.ReadLine();

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}

