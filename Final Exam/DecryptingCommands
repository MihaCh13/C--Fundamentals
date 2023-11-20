using System;
using System.Linq;

namespace DecryptingCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] splitInput = input.Split().ToArray();

                string command = splitInput[0];

                if (command == "Replace")
                {
                    string currentChar = splitInput[1];
                    string newChar = splitInput[2];

                    text = text.Replace(currentChar, newChar);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(splitInput[1]);
                    int endIndex = int.Parse(splitInput[2]);

                    if (startIndex < 0 || endIndex >= text.Length || endIndex < startIndex)
                    {
                        Console.WriteLine("Invalid indices!");
                        continue;
                    }
                    else
                    {
                        int count = endIndex - startIndex + 1;
                        text = text.Remove(startIndex, count);
                    }
                }
                else if (command == "Make")
                {
                    string casing = splitInput[1];

                    if (casing == "Upper")
                    {
                        text = text.ToUpper();
                    }
                    else if (casing == "Lower")
                    {
                        text = text.ToLower();
                    }
                }
                else if (command == "Check")
                {
                    string substring = splitInput[1];

                    if (text.Contains(substring))
                    {
                        Console.WriteLine($"Message contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {substring}");
                    }
                    continue;
                }
                else if (command == "Sum")
                {
                    int startIndex = int.Parse(splitInput[1]);
                    int endIndex = int.Parse(splitInput[2]);

                    if (startIndex < 0 || endIndex >= text.Length || endIndex < startIndex)
                    {
                        Console.WriteLine("Invalid indices!");
                        continue;
                    }
                    else
                    {
                        string substring = text.Substring(startIndex, endIndex);

                        int lettersValue = 0;

                        foreach (char c in substring)
                        {
                            lettersValue += c;
                        }

                        Console.WriteLine(lettersValue);
                        continue;
                    }
                }

                Console.WriteLine(text);
            }
        }
    }
}
