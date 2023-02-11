using System;

namespace _05_Mid_Exam_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents = int.Parse(Console.ReadLine());
            int lecturers = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            double maxAttendance = 0;
           


            for (int i = 0; i < numberStudents; i++)
            {
                double currentAttendance = double.Parse(Console.ReadLine());

                double bonus = (currentAttendance / lecturers) * (5 + additionalBonus);

                if(bonus > maxBonus)
                {
                    maxBonus = bonus;
                    maxAttendance = currentAttendance;
                }
                
            }
            
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
            
        }
    }
}

