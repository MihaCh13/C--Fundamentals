using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> meals = new Dictionary<string, List<string>>();
            int unliked = 0;

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] data = input
                    .Split('-');
                string guest = data[1];
                string meal = data[2];

                switch (data[0])
                {
                    case "Like":
                        if (meals.ContainsKey(guest))
                        {
                            if (!meals[guest].Contains(meal))
                            {
                                meals[guest].Add(meal);
                            }
                        }
                        else
                        {
                            meals.Add(guest, new List<string>());
                            meals[guest].Add(meal);
                        }
                        break;
                    default:
                        if (meals.ContainsKey(guest))
                        {
                            if (meals[guest].Contains(meal))
                            {
                                meals[guest].Remove(meal);
                                Console.WriteLine($"{guest} doesn't like the {meal}.");
                                unliked += 1;
                            }
                            else
                            {
                                Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{guest} is not at the party.");
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            foreach (var item in meals.OrderByDescending(x => x.Value.Count).ThenBy(x=> x.Key))
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unliked}");
        }
    }
}
