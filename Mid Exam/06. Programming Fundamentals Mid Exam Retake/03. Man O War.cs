using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
        List<int> warship = Console.ReadLine().Split(">").Select(int.Parse).ToList();
        int maxHealth = int.Parse(Console.ReadLine());

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Retire")
            {
                break;
            }

            string[] cmdArgs = command.Split();
            string action = cmdArgs[0];

            if (action == "Fire")
            {
                int index = int.Parse(cmdArgs[1]);
                int damage = int.Parse(cmdArgs[2]);

                if (index >= 0 && index < warship.Count)
                {
                    warship[index] -= damage;
                    if (warship[index] <= 0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        return;
                    }
                }
            }
            else if (action == "Defend")
            {
                int startIndex = int.Parse(cmdArgs[1]);
                int endIndex = int.Parse(cmdArgs[2]);
                int damage = int.Parse(cmdArgs[3]);

                if (startIndex >= 0 && startIndex < pirateShip.Count
                    && endIndex >= 0 && endIndex < pirateShip.Count)
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
                int index = int.Parse(cmdArgs[1]);
                int health = int.Parse(cmdArgs[2]);

                if (index >= 0 && index < pirateShip.Count)
                {
                    pirateShip[index] += health;
                    if (pirateShip[index] > maxHealth)
                    {
                        pirateShip[index] = maxHealth;
                    }
                }
            }
            else if (action == "Status")
            {
                int count = pirateShip.Count(p => p < maxHealth * 0.2);
                Console.WriteLine($"{count} sections need repair.");
            }
        }

        int pirateSum = pirateShip.Sum();
        int warshipSum = warship.Sum();
        Console.WriteLine($"Pirate ship status: {pirateSum}");
        Console.WriteLine($"Warship status: {warshipSum}");
    }
}
