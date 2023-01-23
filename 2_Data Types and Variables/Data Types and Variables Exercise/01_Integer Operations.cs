using System;

namespace Data_Types_and_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int sum = ((first + second) / third) * fourth;

            Console.WriteLine(sum);
        }
    }
}

