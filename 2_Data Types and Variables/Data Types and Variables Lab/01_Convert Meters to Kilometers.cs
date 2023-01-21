using System;

namespace Data_Types_and_Variables_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceM = double.Parse(Console.ReadLine());
            double distanceKm = distanceM / 1000;
            Console.WriteLine($"{distanceKm:f2}");
        }
    }
}

