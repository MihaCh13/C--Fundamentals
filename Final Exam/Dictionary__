using System;
using System.Linq;
using System.Collections.Generic;
namespace _03.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordAndDefinitions = Console.ReadLine().Split(" | ").ToArray();
            var noteBook = new Dictionary<string, List<string>>();
            var wordsList = new List<string>();
            for (int i = 0; i < wordAndDefinitions.Length; i++)
            {
                string inputLine = wordAndDefinitions[i];
                string[] wordsWithdefinitions = inputLine.Split(": ");
                string word = wordsWithdefinitions[0];
                string definition = wordsWithdefinitions[1];
                if (!noteBook.ContainsKey(word))
                {
                    noteBook.Add(word, new List<string>());
                }
                noteBook[word].Add(definition);
            }
            string input = Console.ReadLine();
            while ((input != "Test") && (input != "Hand Over"))
            {
                string[] words = input.Split(" | ").ToArray();
                for (int currWord = 0; currWord < words.Length; currWord++)
                {
                    if (!wordsList.Contains(words[currWord]))
                    {
                        wordsList.Add(words[currWord]);
                    }
                }
                input = Console.ReadLine();
            }
            if (input == "Hand Over")
            {
                foreach (var words in noteBook)
                {
                    Console.Write(words.Key + " ");
                }
            }
            else
            {
                foreach (var wordTest in wordsList)
                {
                    foreach (var noteBookWord in noteBook)
                    {
                        if (wordTest == noteBookWord.Key)
                        {
                            Console.WriteLine($"{wordTest}:");
                            foreach (string definitions in noteBookWord.Value)
                            {
                                Console.WriteLine($" -{definitions}");
                            }
                        }
                    }
                }
            }
        }
    }
}
