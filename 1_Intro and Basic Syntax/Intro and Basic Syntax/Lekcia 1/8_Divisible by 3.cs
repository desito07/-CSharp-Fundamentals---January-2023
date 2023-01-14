using System;

namespace Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

