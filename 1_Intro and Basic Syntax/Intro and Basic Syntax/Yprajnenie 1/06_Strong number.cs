using System;

namespace Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int numbercopy = num;
            int sum = 0;

            while(numbercopy > 0)
            {
                int digit = numbercopy % 10;
                numbercopy = numbercopy / 10;

                int factorial = 1;

                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
            }
            if(sum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }    
        }
    }
}

