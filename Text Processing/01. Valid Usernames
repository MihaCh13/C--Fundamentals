using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string usernames = Console.ReadLine();
        List<string> users = usernames.Split(", ").ToList();
        List<string> validNames = new List<string>();

        foreach (string user in users)
        {
            char[] letters = user.ToCharArray();

            if (letters.Length >= 3 && letters.Length <= 16 && IsValidCharacters(letters))
            {
                validNames.Add(user);
            }
        }

        foreach (string validName in validNames)
        {
            Console.WriteLine(validName);
        }
    }

    static bool IsValidCharacters(char[] letters)
    {
        foreach (char letter in letters)
        {
            if (!char.IsLetterOrDigit(letter) && letter != '-' && letter != '_')
            {
                return false;
            }
        }
        return true;
    }
}
