using System;

namespace Mid_Exam_190223
{
    class Program
    {
        public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourSinglePrice = double.Parse(Console.ReadLine());
            double eggSinglePrice = double.Parse(Console.ReadLine());
            double apronSinglePrice = double.Parse(Console.ReadLine());


            double flourCost = 0.0;
            int flourPacks = (int)Math.Ceiling((double)students / 5);
            for (int i = 1; i <= flourPacks; i++)
            {
                if (i == flourPacks && students % 5 != 0)
                {
                    int remainingPacks = students % 5;
                    flourCost += remainingPacks * flourSinglePrice;
                }
                else
                {
                    flourCost += 4 * flourSinglePrice;
                }
            }


            double eggCosts = students * eggSinglePrice * 10;
            double apronCosts = apronSinglePrice * Math.Ceiling(students * 1.2);

            double costs = flourCost + eggCosts + apronCosts;

            if (costs <= budget)
            {
                Console.WriteLine($"Items purchased for {costs:f2}$.");
            }
            else
            {
                Console.WriteLine($"{costs - budget:f2}$ more needed.");
            }
        }
    }
}