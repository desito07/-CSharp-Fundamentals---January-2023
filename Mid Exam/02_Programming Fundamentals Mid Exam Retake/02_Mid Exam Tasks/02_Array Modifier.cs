using System;
using System.Linq;


namespace _02_Mid_Exam_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            


            while(true)
            {
                string[] arr = Console.ReadLine().Split();

                if (arr[0] == "end")
                {
                    break;
                }
                else if (arr[0] == "swap")
                {
                    int index1 = int.Parse(arr[1]);
                    int index2 = int.Parse(arr[2]);
                    int temp = num[index1];

                    num[index1] = num[index2];
                    num[index2] = temp;
                }
                else if (arr[0] == "multiply")
                {
                    int indexOne = int.Parse(arr[1]);
                    int indexTwo = int.Parse(arr[2]);

                    num[indexOne] = num[indexOne] * num[indexTwo];
                }
                else
                {
                    for (int i = 0; i < num.Length; i++)
                    {
                        num[i] = num[i] - 1;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", num));
        }
    }
}

