//using System;

//namespace _01_Mid_Exam_Tasks
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double sumNoTax = 0.0;
//            string command = Console.ReadLine();
           

//            while (command != "special" && command != "regular")
//            {
//                double current = double.Parse(command);
//                if (current <= 0)
//                    {
//                        Console.WriteLine("Invalid price!");
//                    }
//                    else
//                    {
//                    sumNoTax += current;
//                    }

//                    command = Console.ReadLine();
//                }

//            double tax = sumNoTax * 0.2;
//            double totalSum = sumNoTax + tax;

//            if (totalSum == 0)
//            {
//                Console.WriteLine("Invalid order!");
//                return;
//            }

//            if (command == "special")
//                {
//                double discount = 0.1;
//                totalSum -= totalSum * discount;
//                }
          

//            Console.WriteLine("Congratulations you've just bought a new computer!");
//            Console.WriteLine($"Price without taxes: {sumNoTax:f2}$");
//            Console.WriteLine($"Taxes: {tax:f2}$");
//            Console.WriteLine("-----------");
//            Console.WriteLine($"Total price: {totalSum:F2}$");

//        }
//    }
//}

