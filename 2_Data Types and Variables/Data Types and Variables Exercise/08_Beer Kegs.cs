using System;

namespace Data_Types_and_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numKegs = int.Parse(Console.ReadLine());

            string bestModel = "";
            double biggestValue = 0.0;

            for (int i = 0; i < numKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if(volume > biggestValue)
                {
                    biggestValue = volume;
                    bestModel = model;
                }
            }
            Console.WriteLine(bestModel);
        }
    }
}

