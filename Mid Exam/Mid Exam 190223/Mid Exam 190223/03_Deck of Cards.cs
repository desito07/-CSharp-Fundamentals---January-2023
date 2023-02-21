using System;
using System.Collections.Generic;
using System.Linq;

namespace Mid_Exam_190223
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ");

                if (command[0] == "Add")
                {
                    if (cards.Contains(command[1]))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        cards.Add(command[1]);
                        Console.WriteLine("Card successfully added");
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (cards.Contains(command[1]))
                    {
                        cards.Remove(command[1]);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (command[0] == "Remove At")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index >= cards.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        cards.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index >= cards.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else if (cards.Contains(command[2]))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        cards.Insert(index, command[2]);
                        Console.WriteLine("Card successfully added");
                    }
                }
            }

            Console.WriteLine(string.Join(", ", cards));
        }
    }
}