using System;
using System.Linq;
using System.Collections.Generic;

namespace WildZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, AnimalInfo> animals = new Dictionary<string, AnimalInfo>();
            Dictionary<string, int> areas = new Dictionary<string, int>();
            
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "EndDay")
            {
                string[] splitInput = input.Split(new char[] {':', ' ', '-'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = splitInput[0];
                string name = splitInput[1];
                int food = int.Parse(splitInput[2]);

                if (command == "Add")
                {
                    string area = splitInput[3];

                    if (animals.ContainsKey(name))
                    {
                        animals[name].FoodNeeded += food;
                    }
                    else
                    {
                        animals.Add(name, new AnimalInfo(food, area));

                        if (areas.ContainsKey(area))
                        {
                            areas[area]++;
                        }
                        else
                        {
                            areas.Add(area, 1);
                        }
                    }
                }
                else if (command == "Feed")
                {
                    if (animals.ContainsKey(name))
                    {
                        animals[name].FoodNeeded -= food;
                        string area = animals[name].Area;

                        if (animals[name].FoodNeeded <= 0)
                        {
                            areas[area]--;
                            animals.Remove(name);
                            Console.WriteLine($"{name} was successfully fed");
                        }
                    }
                }
            }

            areas = areas.Where(x => x.Value != 0).ToDictionary(x=> x.Key, x=> x.Value);

            Console.WriteLine("Animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine($" {animal.Key} -> {animal.Value.FoodNeeded}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach(var area in areas)
            {
                Console.WriteLine($"{area.Key}: {area.Value}");
            }
        }
    }

    public class AnimalInfo
    {
        public AnimalInfo(int food, string area)
        {
            FoodNeeded = food;

            Area = area;
        }
        
        public int FoodNeeded { get; set; }

        public string Area { get; set; }
    }
}
