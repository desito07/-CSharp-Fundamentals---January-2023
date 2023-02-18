using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
        List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
        int maxHealth = int.Parse(Console.ReadLine());

        string command = Console.ReadLine();
        while (command != "Retire")
        {
            string[] tokens = command.Split();
            string action = tokens[0];

            if (action == "Fire")
            {
                int index = int.Parse(tokens[1]);
                int damage = int.Parse(tokens[2]);
                if (index >= 0 && index < warShip.Count)
                {
                    warShip[index] -= damage;
                    if (warShip[index] <= 0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        return;
                    }
                }
            }
            else if (action == "Defend")
            {
                int startIndex = int.Parse(tokens[1]);
                int endIndex = int.Parse(tokens[2]);
                int damage = int.Parse(tokens[3]);
                if (startIndex >= 0 && startIndex < pirateShip.Count && endIndex >= 0 && endIndex < pirateShip.Count)
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        pirateShip[i] -= damage;
                        if (pirateShip[i] <= 0)
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            return;
                        }
                    }
                }
            }
            else if (action == "Repair")
            {
                int index = int.Parse(tokens[1]);
                int health = int.Parse(tokens[2]);
                if (index >= 0 && index < pirateShip.Count)
                {
                    pirateShip[index] = Math.Min(pirateShip[index] + health, maxHealth);
                }
            }
            else if (action == "Status")
            {
                int count = pirateShip.Count(x => x < maxHealth * 0.2);
                Console.WriteLine($"{count} sections need repair.");
            }

            command = Console.ReadLine();
        }

        int pirateShipSum = pirateShip.Sum();
        int warShipSum = warShip.Sum();
        Console.WriteLine($"Pirate ship status: {pirateShipSum}");
        Console.WriteLine($"Warship status: {warShipSum}");
    }
}
