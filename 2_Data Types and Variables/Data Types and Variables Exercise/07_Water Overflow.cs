using System;

namespace Data_Types_and_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (current <= 255 - sum)
                {
                    sum += current;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(sum);

        }
    }
}
