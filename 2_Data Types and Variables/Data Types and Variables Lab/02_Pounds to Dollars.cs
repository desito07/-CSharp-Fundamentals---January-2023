using System;

namespace Data_Types_and_Variables_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double gbr = double.Parse(Console.ReadLine());
            double usd = gbr * 1.31;
            Console.WriteLine($"{usd:f3}");
        }
    }
}

