using System;
using System.Text.RegularExpressions;
namespace _02.EncryptingPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string pattern = @"(?<startSymbols>\S+)>(?<first>[0-9]{3})[|](?<second>[a-z]{3})[|](?<third>[A-Z]{3})[|](?<fourth>[^><]{3})<(?<endSymbols>\S+)";            
            Regex regex = new Regex(pattern);
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                Match matches = regex.Match(input);
                var startSymbols = matches.Groups["startSymbols"].Value;
                var endSymbols = matches.Groups["endSymbols"].Value;
                var first = matches.Groups["first"].Value;
                var second = matches.Groups["second"].Value;
                var third = matches.Groups["third"].Value;
                var fourth = matches.Groups["fourth"].Value;
                if (matches.Success && startSymbols.ToString() == endSymbols.ToString())
                {
                    Console.WriteLine($"Password: {first}{second}{third}{fourth}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
