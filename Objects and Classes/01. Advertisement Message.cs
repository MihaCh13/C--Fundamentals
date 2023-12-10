using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Phrases
    {
        public static List<string> phrases = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
    }

    public class Events
    {
        public static List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
    }

    public class Authors
    {
        public static List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
    }

    public class Cities
    {
        public static List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int generations = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < generations; i++)
            {
                string praseRandomValue = Phrases.phrases[random.Next(Phrases.phrases.Count)];
                string eventRandomValue = Events.events[random.Next(Events.events.Count)];
                string authorRandomValue = Authors.authors[random.Next(Authors.authors.Count)];
                string cityRandomValue = Cities.cities[random.Next(Cities.cities.Count)];

                Console.WriteLine($"{praseRandomValue} {eventRandomValue} {authorRandomValue} – {cityRandomValue}.");
            }
        }
    }
}
