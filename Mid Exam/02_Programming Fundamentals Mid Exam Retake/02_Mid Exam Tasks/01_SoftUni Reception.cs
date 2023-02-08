using System;

namespace _02_Mid_Exam_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int empl1 = int.Parse(Console.ReadLine());
            int empl2 = int.Parse(Console.ReadLine());
            int empl3 = int.Parse(Console.ReadLine());

            int studentCount = int.Parse(Console.ReadLine());

            int efficiency = empl1 + empl2 + empl3;

            double time = 0;

            while (studentCount > 0)
            {
                time++;

                if (time % 4 == 0)
                {
                    time++;
                }
                studentCount -= efficiency;
            }
            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}

