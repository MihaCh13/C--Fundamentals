using System;
using System.Text.RegularExpressions;

namespace _02._Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {


            string pattern = @"\|(?<name>[A-Z]{4,})\|:\#(?<title>[A-Za-z]+ [A-Za-z]+)\#";
            int n = int.Parse(Console.ReadLine());           

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var matches = Regex.Matches(input, pattern);

                foreach (Match name in matches)
                {
                    string bossName = name.Groups["name"].Value;
                    string title = name.Groups["title"].Value;
                    int strength = bossName.Length;
                    int armor = title.Length;

                    Console.WriteLine($"{bossName}, The {title}");
                    Console.WriteLine($">> Strength: {strength}");
                    Console.WriteLine($">> Armor: {armor}");
                }

                if (matches.Count == 0)
                {
                    Console.WriteLine("Access denied!");
                }

            }
        }
    }
}
