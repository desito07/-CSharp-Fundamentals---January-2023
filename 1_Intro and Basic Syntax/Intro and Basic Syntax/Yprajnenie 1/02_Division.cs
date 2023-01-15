using System;

namespace Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int division = 0;

            if(num % 2 == 0 || num % 3 == 0 || num % 6 == 0)
            {
                division = 6;
                Console.WriteLine($"The number is divisible by {division}");
            }
            else if(num % 2 == 0 || num % 10 == 0)
            {
                division = 10;
                Console.WriteLine($"The number is divisible by {division}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}

