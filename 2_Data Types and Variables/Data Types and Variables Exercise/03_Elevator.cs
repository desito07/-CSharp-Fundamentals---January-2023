using System;

namespace Data_Types_and_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int course = numPeople / capacity;

            if(numPeople % capacity != 0)
            {
                course++;
            }
            Console.WriteLine(course);
        }
    }
}

