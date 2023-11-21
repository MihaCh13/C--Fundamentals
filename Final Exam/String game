using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] currentCommand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (currentCommand[0])
                {
                    case "Change":
                        char symbol = char.Parse(currentCommand[1]);
                        char replacement = char.Parse(currentCommand[2]);

                        if (text.Contains(symbol))
                        {
                            text = text.Replace(symbol, replacement);
                            Console.WriteLine(text);
                        }
                        else
                        {
                            Console.WriteLine(text);
                        }

                        break;
                    case "Includes":
                        string substringToCheck = currentCommand[1];

                        if (text.Contains(substringToCheck))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }

                        break;
                    case "End":
                        string endSubstring = currentCommand[1];
                        int startIndex = text.IndexOf(endSubstring);
                        int endIndex = startIndex + endSubstring.Length - 1;

                        if (text[endIndex] == text[text.Length - 1])
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        
                        break;
                    case "Uppercase":
                        text = text.ToUpper();
                        Console.WriteLine(text);
                        break;
                    case "FindIndex":
                        char symbolToFind = char.Parse(currentCommand[1]);
                        int index = text.IndexOf(symbolToFind);
                        Console.WriteLine(index);
                        break;
                    case "Cut":
                        int startIndexToCut = int.Parse(currentCommand[1]);
                        
                        if (startIndexToCut >=0 && startIndexToCut < text.Length)
                        {
                            int count = int.Parse(currentCommand[2]);
                            string cut = text.Substring(startIndexToCut, count);
                            text = cut;
                            Console.WriteLine(text);
                        }
                   
                        break;

                    default:
                        break;
                }


                input = Console.ReadLine();
            }
        }
    }
}
