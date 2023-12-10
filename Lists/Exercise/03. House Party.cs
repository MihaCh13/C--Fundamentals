using System;
using System.Collections.Generic;
using System.Linq;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guestsNames = new List<string>();
            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                List<string> guests = Console.ReadLine().Split(' ').ToList();

                if (guests[2] == "going!")
                {
                    if (!guestsNames.Contains(guests[0]))
                    {
                        guestsNames.Add(guests[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{guests[0]} is already in the list!");
                    }
                }
                else
                {
                    if (!guestsNames.Contains(guests[0]))
                    {
                        Console.WriteLine($"{guests[0]} is not in the list!");
                    }
                    else
                    {
                        guestsNames.Remove(guests[0]);
                    }
                }
            }

            foreach (string name in guestsNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
