using System;

namespace Data_Types_and_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                char current = char.Parse(Console.ReadLine());
                sum += current;
                //if(current >= 65 && current <= 122)
                //{
                //    sum += current; 
                //}
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}

