using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> participants = new Dictionary<string, int>();
            List<string> names = input.Split(", ").ToList();
            foreach (var name in names)
            {
                participants.Add(name, 0); 
            }

            string info = Console.ReadLine();

            while (info != "end of race")
            {
                string regexLetters = @"[A-Za-z]";
                string regexTwo = @"\d";
                string currName = String.Empty;
                int currNumbers = 0;
                MatchCollection letters = Regex.Matches(info, regexLetters, RegexOptions.IgnoreCase);
                foreach (Match VARIABLE in letters)
                {
                    currName += (VARIABLE.ToString());
                }
                MatchCollection numbers = Regex.Matches(info, regexTwo, RegexOptions.IgnoreCase);
                foreach (Match VARIABLE in numbers)
                {
                    currNumbers += int.Parse(VARIABLE.Value);
                }

                if (participants.ContainsKey(currName))
                {
                    participants[currName] += currNumbers;
                }
                info = Console.ReadLine();
            }

            participants = participants.OrderByDescending(pair => pair.Value)
                .ToDictionary(pair => pair.Key,
                    pair => pair.Value);
            int count = 1;
            foreach (var VARIABLE in participants)
            {
                if (count <= 3)
                {
                    if (count == 1)
                    {
                        Console.WriteLine($"1st place: {VARIABLE.Key}");
                    }
                    else if (count == 2)
                    {
                        Console.WriteLine($"2nd place: {VARIABLE.Key}");
                    }
                    else if (count == 3)
                    {
                        Console.WriteLine($"3rd place: {VARIABLE.Key}");
                    }


                }
                else
                {
                    return;
                }
                count++;

            }
        }
    }
}
