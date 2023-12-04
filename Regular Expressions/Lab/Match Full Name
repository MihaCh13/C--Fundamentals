using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string names = Console.ReadLine();
        string pattern = @"\b(?<FirstName>[A-Z]{1}[a-z]+) (?<SecondName>[A-Z]{1}[a-z]+)\b";
        MatchCollection matchNames = Regex.Matches(names, pattern);

        foreach (Match name in matchNames)
        {
            string firstName = name.Groups["FirstName"].Value;
            string secondName = name.Groups["SecondName"].Value;
            Console.Write(firstName + " " + secondName + " ");
        }
    }
}
