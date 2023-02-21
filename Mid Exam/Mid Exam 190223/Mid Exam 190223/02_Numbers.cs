using System;
using System.Collections.Generic;
using System.Linq;

namespace Mid_Exam_190223
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                     .Split(' ')
                                     .Select(int.Parse)
                                     .ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "Finish")
                {
                    break;
                }

                else if (command[0] == "Add")
                {
                    int temp = int.Parse(command[1]);
                    numbers.Add(temp);
                }
                else if (command[0] == "Remove")
                {
                    int value = int.Parse(command[1]);
                    numbers.Remove(value);
                }
                else if (command[0] == "Replace")
                {
                    int temp1 = int.Parse(command[1]);
                    int replacement = int.Parse(command[2]);
                    int index = numbers.IndexOf(temp1);
                    if (index != -1)
                    {
                        numbers[index] = replacement;
                    }
                }
                else if (command[0] == "Collapse")
                {
                    int value1 = int.Parse(command[1]);
                    numbers = numbers.Where(x => x >= value1).ToList();
                }

            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
