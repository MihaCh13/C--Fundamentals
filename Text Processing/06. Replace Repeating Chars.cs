using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string result = RemoveConsecutiveDuplicates(input);

        Console.WriteLine(result);
    }

    static string RemoveConsecutiveDuplicates(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        char currentChar = input[0];
        System.Text.StringBuilder result = new System.Text.StringBuilder();

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != currentChar)
            {
                result.Append(currentChar);
                currentChar = input[i];
            }
        }

        // Append the last character
        result.Append(currentChar);

        return result.ToString();
    }
}
