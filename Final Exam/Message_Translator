using System;
using System.Text.RegularExpressions;

namespace _02._Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string message = Console.ReadLine();

                Match match = Regex.Match(message, @"!([A-Z][a-z]{2,})!:\[([A-Za-z]{8,})\]");

                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }
                else
                {
                    string messageInfo = match.Groups[2].Value;
                    int[] ASCIIvalues = new int[messageInfo.Length];

                    for (int j = 0; j < ASCIIvalues.Length; j++)
                    {
                        ASCIIvalues[j] = messageInfo[j];
                    }
                    Console.WriteLine($"{match.Groups[1].Value}: {string.Join(' ', ASCIIvalues)}");
                }
               
            }
        }
    }
}
