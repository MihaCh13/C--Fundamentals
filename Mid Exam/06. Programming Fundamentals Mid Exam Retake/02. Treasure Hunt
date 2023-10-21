using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> treasureChest = Console.ReadLine().Split("|").ToList();

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "Yohoho!")
            {
                break;
            }

            string[] cmdArgs = command.Split();
            string action = cmdArgs[0];

            if (action == "Loot")
            {
                for (int i = 1; i < cmdArgs.Length; i++)
                {
                    string item = cmdArgs[i];
                    if (!treasureChest.Contains(item))
                    {
                        treasureChest.Insert(0, item);
                    }
                }
            }
            else if (action == "Drop")
            {
                int index = int.Parse(cmdArgs[1]);
                if (index >= 0 && index < treasureChest.Count)
                {
                    string item = treasureChest[index];
                    treasureChest.RemoveAt(index);
                    treasureChest.Add(item);
                }
            }
            else if (action == "Steal")
            {
                int count = int.Parse(cmdArgs[1]);
                if (count >= treasureChest.Count)
                {
                    count = treasureChest.Count;
                }

                List<string> stolenItems = treasureChest.GetRange(treasureChest.Count - count, count);
                treasureChest.RemoveRange(treasureChest.Count - count, count);
                Console.WriteLine(string.Join(", ", stolenItems));
            }
        }

        if (treasureChest.Count == 0)
        {
            Console.WriteLine("Failed treasure hunt.");
        }
        else
        {
            double averageGain = treasureChest.Sum(item => item.Length) / (double)treasureChest.Count;
            Console.WriteLine($"Average treasure gain: {averageGain:F2} pirate credits.");
        }
    }
}
