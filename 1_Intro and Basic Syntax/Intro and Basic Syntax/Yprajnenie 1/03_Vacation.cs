using System;

namespace Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string people = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0.0;


            if (day == "Friday")
            {
                if (people == "Students")
                {
                    price = 8.45;
                }
                else if (people == "Business")
                {
                    price = 10.90;
                }
                else if (people == "Regular")
                {
                    price = 15;
                }
            }
            else if (day == "Saturday")
            {
                if (people == "Students")
                {
                    price = 9.80;
                }
                else if (people == "Business")
                {
                    price = 15.60;
                }
                else if (people == "Regular")
                {
                    price = 20;
                }
            }
            else if (day == "Sunday")
            {
                if (people == "Students")
                {
                    price = 10.46;
                }
                else if (people == "Business")
                {
                    price = 16;
                }
                else if (people == "Regular")
                {
                    price = 22.50;
                }
            }
            if (people == "Students" && count >= 30)
            {
                price -= price * 0.15;
            }
            else if (people == "Business" && count >= 100)
            {
                count -= 10;
            }
            else if (people == "Regular" && count >= 10 && count <= 20)
            {
                price -= price * 0.05;
            }
            double totalPrice = price * count;
            Console.Write($"Total price: {totalPrice:f2}");

        }
    }
}
