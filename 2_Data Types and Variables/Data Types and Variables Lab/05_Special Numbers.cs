using System;

namespace Data_Types_and_Variables_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= num; i++)
            {
                int current = i; // sum of digits = 5 || 7 || 11
                int sum = 0;

                while (current > 0)
                {
                    sum += current % 10;

                    current /= 10;
                }
                // if num is magic
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}

