using System;
using System.Linq;

namespace _01_Mid_Exam_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            int people = int.Parse(Console.ReadLine());
            int[] lifts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < lifts.Length; i++)
            {
                if (lifts[i] < 4)
                    while (lifts[i] != 4 && people > 0)
                    {
                        lifts[i]++;
                        people--;
                    }
            }

            if (people == 0 && lifts[lifts.Length - 1] == 4) { }
            else if (people == 0)
                Console.WriteLine("The lift has empty spots!");
            else
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");

            Console.WriteLine(String.Join(" ", lifts));
        }
    }
}


