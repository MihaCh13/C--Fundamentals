using System;
using System.Text;

class Program
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        string result = ProcessExplosions(inputString);

        Console.WriteLine($"{result}");

        Console.ReadLine();
    }

    static string ProcessExplosions(string input)
    {
        StringBuilder result = new StringBuilder();
        int explosionStrength = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            if (currentChar == '>')
            {
                // Find the explosion strength
                int strengthIndex = i + 1;
                while (strengthIndex < input.Length && char.IsDigit(input[strengthIndex]))
                {
                    explosionStrength += int.Parse(input[strengthIndex].ToString());
                    strengthIndex++;
                }

                // Add the explosion character
                result.Append('>');
            }
            else if (explosionStrength == 0)
            {
                // If there's no explosion strength, add the character to the result
                result.Append(currentChar);
            }
            else
            {
                // Skip characters based on explosion strength
                explosionStrength--;
            }
        }

        return result.ToString();
    }
}
