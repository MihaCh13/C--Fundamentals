using System;
using System.Text.RegularExpressions;

namespace _003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input  = Console.ReadLine();
            string pattern = @"([@|#]|[@#])+([a-z]{3,})([@|#]|[@#])+([^A-Za-z\d])*(\/+(\d+)\/+)";

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);

            if (matchCollection.Count > 0)
            {
                foreach (Match item in matchCollection)
                {
                    Console.WriteLine($"You found {item.Groups[6].Value} {item.Groups[2].Value} eggs!");
                }
            }
        }
    }
}
