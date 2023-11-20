using System;
using System.Linq;

namespace Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Reveal")
            {
                string[] currCommands = command.Split(":|:");
                if (currCommands[0] == "InsertSpace")
                {
                    int index = int.Parse(currCommands[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (currCommands[0] == "Reverse")
                {
                    string substring = currCommands[1];
                    if (message.Contains(substring))
                    {
                        int currIndex = message.IndexOf(substring);
                        message = message.Remove(currIndex, substring.Length);
                        message = message + string.Join("", substring.Reverse());
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (currCommands[0] == "ChangeAll")
                {
                    string substring = currCommands[1];
                    string replacement = currCommands[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
                

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
