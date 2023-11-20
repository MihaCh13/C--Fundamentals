using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex =
                @"^(\$|%)(?<word>[A-Z][a-z][a-z]+)(\1:\s)(\[(?<number1>\d+)\]\|)(\[(?<number2>\d+)\]\|)(\[(?<number3>\d+)\]\|)$";

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex newRegex = new Regex(regex);
                MatchCollection matches = newRegex.Matches(input);
                int numOne = 0;
                int numTwo = 0;
                int numThree = 0;
                if (matches.Count > 0)
                {

                    foreach (Match VARIABLE in matches)
                    {
                        numOne = int.Parse(VARIABLE.Groups["number1"].ToString());
                        numTwo = int.Parse(VARIABLE.Groups["number2"].ToString());
                        numThree = int.Parse(VARIABLE.Groups["number3"].ToString());



                        Console.WriteLine($"{VARIABLE.Groups["word"]}: {Convert.ToChar(numOne)}{Convert.ToChar(numTwo)}{Convert.ToChar(numThree)}");
                    }



                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }


            }
        }
    }
}
