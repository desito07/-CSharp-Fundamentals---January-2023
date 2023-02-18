using System;
using System.Linq;

namespace _03_Mid_Exam_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int counter = 0;


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                int index = int.Parse(command);

                if (index < 0 || index >= numbers.Length || numbers[index] == -1)
                {
                    continue;
                }

                int value = numbers[index];
                counter++;
                numbers[index] = -1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > value)
                    {
                        numbers[i] -= value;
                    }
                    else if (numbers[i] <= value && numbers[i] != -1)
                    {
                        numbers[i] += value;
                    }

                }
            }
            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", numbers)}");
        }
    }
}

