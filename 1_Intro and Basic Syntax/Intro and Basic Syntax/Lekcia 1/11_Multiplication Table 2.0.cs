using System;

namespace Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{n} X {y} = {n * y}");
                y++;
            }
            while (y <= 10);
        }
    }
}

