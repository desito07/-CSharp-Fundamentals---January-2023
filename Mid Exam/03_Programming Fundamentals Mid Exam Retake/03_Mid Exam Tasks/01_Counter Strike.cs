using System;

namespace _03_Mid_Exam_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int startEnergy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter = 0;
            while (command != "End of battle")
            {
                int currentEnergy = int.Parse(command);
                startEnergy -= currentEnergy;
                counter++;
                if (counter % 3 == 0)
                {
                    startEnergy += counter;
                }
                if (startEnergy <= 0)
                {
                    break;
                }

                command = Console.ReadLine();
            }
            if (startEnergy < 0)
            {
                Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {startEnergy} energy");
            }
            else
            {
                Console.WriteLine($"Won battles: {counter}. Energy left: {startEnergy}");
            }
        }
    }
}


