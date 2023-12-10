using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var information = new Dictionary<string, int>();
        while (true)
        {
            string resource = Console.ReadLine();
            if (string.Equals(resource, "stop", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            int quantity = int.Parse(Console.ReadLine());

            if (!information.ContainsKey(resource))
            {
                information.Add(resource, quantity);
            }
            else
            {
                information[resource] += quantity;
            }
        }

        foreach (KeyValuePair<string, int> pair in information)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}
