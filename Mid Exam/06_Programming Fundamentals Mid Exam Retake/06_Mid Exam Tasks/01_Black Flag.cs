//using System;

//namespace _06_Mid_Exam_Tasks
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int days = int.Parse(Console.ReadLine());
//            int dailyPlunder = int.Parse(Console.ReadLine());
//            double expectedplunder = double.Parse(Console.ReadLine());

//            double targetPlunder = 0;

//            for (int i = 1; i <= days; i++)
//            {
//                targetPlunder += dailyPlunder;

//                if(i % 3 == 0)
//                {
//                    targetPlunder += dailyPlunder * 0.5;
//                }

//                if(i % 5 == 0)
//                {
//                    targetPlunder -= targetPlunder * 0.3;
//                }
//            }
//            if(targetPlunder >= expectedplunder)
//            {
//                Console.WriteLine($"Ahoy! {targetPlunder:f2} plunder gained.");
//            }
//            else
//            {
//                double percentage = (targetPlunder / expectedplunder) * 100;
//                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
//            }
//        }
//    }
//}

