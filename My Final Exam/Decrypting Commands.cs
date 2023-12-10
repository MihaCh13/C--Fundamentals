using System;

class Program
{
    static void Main()
    {
        string message = Console.ReadLine();

        string command;
        while ((command = Console.ReadLine()) != "Finish")
        {
            string[] tokens = command.Split();
            string action = tokens[0];

            switch (action)
            {
                case "Replace":
                    char currentChar = char.Parse(tokens[1]);
                    char newChar = char.Parse(tokens[2]);
                    message = Replace(message, currentChar, newChar);
                    break;

                case "Cut":
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    message = Cut(message, startIndex, endIndex);
                    break;

                case "Make":
                    string caseType = tokens[1];
                    message = Make(message, caseType);
                    break;

                case "Check":
                    string checkString = tokens[1];
                    Check(message, checkString);
                    break;

                case "Sum":
                    startIndex = int.Parse(tokens[1]);
                    endIndex = int.Parse(tokens[2]);
                    Sum(message, startIndex, endIndex);
                    break;

                default:
                    break;
            }
        }
    }

    static string Replace(string message, char currentChar, char newChar)
    {
        message = message.Replace(currentChar, newChar);
        Console.WriteLine(message);
        return message;
    }

    static string Cut(string message, int startIndex, int endIndex)
    {
        if (IsValidIndex(message, startIndex) && IsValidIndex(message, endIndex))
        {
            message = message.Remove(startIndex, endIndex - startIndex + 1);
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("Invalid indices!");
        }

        return message;
    }

    static string Make(string message, string caseType)
    {
        if (caseType == "Upper")
        {
            message = message.ToUpper();
        }
        else if (caseType == "Lower")
        {
            message = message.ToLower();
        }

        Console.WriteLine(message);
        return message;
    }

    static void Check(string message, string checkString)
    {
        if (message.Contains(checkString))
        {
            Console.WriteLine($"Message contains {checkString}");
        }
        else
        {
            Console.WriteLine($"Message doesn't contain {checkString}");
        }
    }

    static void Sum(string message, int startIndex, int endIndex)
    {
        if (IsValidIndex(message, startIndex) && IsValidIndex(message, endIndex))
        {
            int sum = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                sum += (int)message[i];
            }
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("Invalid indices!");
        }
    }

    static bool IsValidIndex(string message, int index)
    {
        return index >= 0 && index < message.Length;
    }
}
