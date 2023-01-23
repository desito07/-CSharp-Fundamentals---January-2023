using System;

namespace Data_Types_and_Variables_Lab
{
    class Program
    {
        static void Main(string[] args)
        {


            //int kolkko = int.Parse(Console.ReadLine());
            //int obshto = 0;
            //int takova = 0;
            //bool toe = false;
            //for (int ch = 1; ch <= kolkko; ch++)
            //{
            //    takova = ch;
            //    while (ch > 0)
            //    {
            //        obshto += ch % 10;
            //        ch = ch / 10;
            //    }
            //    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            //    Console.WriteLine("{0} -> {1}", takova, toe);
            //    obshto = 0;
            //    ch = takova;

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int current = i; // sum of digits = 5 || 7 || 11
                int sum = 0;

                while (current > 0)
                {
                    sum += current % 10;

                    current /= 10;
                }
                // if num is magic
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

            }
        }
    }
}

