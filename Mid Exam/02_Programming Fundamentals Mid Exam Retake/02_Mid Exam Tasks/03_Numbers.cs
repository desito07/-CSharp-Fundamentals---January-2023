using System;
using System.Linq;


namespace _02_Mid_Exam_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            int average = (int)numbers.Average();

            int[] result = numbers
                .Where(c => c > average)
                .OrderByDescending(c => c)
                .Take(5)
                .ToArray();

            if(result.Length > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

