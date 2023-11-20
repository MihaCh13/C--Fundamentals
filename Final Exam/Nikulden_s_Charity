using System;
using System.Text;

namespace _01._Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Finish")
                {
                    break;
                }

                if (command[0] == "Replace")
                {
                    char current = char.Parse(command[1]);
                    char newChar = char.Parse(command[2]);

                    message = message.Replace(current, newChar);
                    Console.WriteLine(message);

                }
                else if (command[0] == "Cut")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0 || startIndex > message.Length - 1 
                        || endIndex < 0 || endIndex > message.Length - 1)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        message = message.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(message);
                    }
                }
                else if (command[0] == "Make")
                {
                    if (command[1] == "Upper")
                    {
                        message = message.ToUpper();
                    }
                    else
                    {
                        message = message.ToLower();
                    }
                    Console.WriteLine(message);
                }
                else if (command[0] == "Check")
                {
                    string substring = command[1];

                    if (message.Contains(substring))
                    {
                        Console.WriteLine($"Message contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {substring}");
                    }
                }
                else if (command[0] == "Sum")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0 || startIndex > message.Length - 1
                        || endIndex < 0 || endIndex > message.Length - 1)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        string substring = message.Substring(startIndex, endIndex - startIndex + 1);
                        int sum = 0;

                        foreach (var item in substring)
                        {
                            sum += item;
                        }

                        Console.WriteLine(sum);
                    }
                }
            }
        }
    }
}
