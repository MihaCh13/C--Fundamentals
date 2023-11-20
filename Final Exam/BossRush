using System;
using System.Text.RegularExpressions;

namespace BossRush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\|(?<name>[A-Z]{4,})\|\:\#(?<title>[A-Za-z]+\s{1}[A-Za-z]+)\#";

            int bossesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < bossesCount; i++)
            {
                string boss = Console.ReadLine();
                Match validBoss = Regex.Match(boss, pattern);

                if (validBoss.Success)
                {
                    string bossName = validBoss.Groups["name"].Value;
                    string bossTitle = validBoss.Groups["title"].Value;

                    int strength = bossName.Length;
                    int armor = bossTitle.Length;

                    Console.WriteLine($"{bossName}, The {bossTitle} \n>> Strength: {strength} \n>> Armor: {armor}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
