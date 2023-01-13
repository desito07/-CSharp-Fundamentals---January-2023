using System;

namespace Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string country  = Console.ReadLine();

            if(country == "USA" || country == "England")
            {
                Console.WriteLine("English");
            }
            else if(country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
                
        }
    }
}


