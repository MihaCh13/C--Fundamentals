using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        var id = new Dictionary<string, string>();

        for (int i = 0; i < num; i++)
        {
            string[] information = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = information[0];
            string name = information[1];

            if (command == "unregister")
            {
                if (id.ContainsKey(name))
                {
                    id.Remove(name);
                    Console.WriteLine($"{name} unregistered successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: user {name} not found");
                }
            }
            else
            {
                string number = information[2];

                if (!id.ContainsKey(name))
                {
                    id.Add(name, number);
                    Console.WriteLine($"{name} registered {number} successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: already registered with plate number {number}");
                }
            }
        }

        // Print registered users
        foreach (KeyValuePair<string, string> kvp in id)
        {
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        }
    }
}
