using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _002
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            string commandInput = string.Empty;
            while ((commandInput = Console.ReadLine()) != "End")
            {
                string[] commands = commandInput.Split(' ').Select(z => z.Trim()).ToArray();
                if (commands[0] == "Enroll")
                {
                    string name = commands[1];
                    if (!heroes.ContainsKey(name))
                    {
                        heroes.Add(name, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already enrolled.");
                    }

                }
                else if (commands[0] == "Learn")
                {
                    string name = commands[1];
                    string spell = commands[2];
                    if (heroes.ContainsKey(name))
                    {
                        if (!heroes[name].Contains(spell))
                        {
                            heroes[name].Add(spell);
                            
                        }
                        else
                        {
                            Console.WriteLine($"{name} has already learnt {spell}.");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }


                }
                else if (commands[0] == "Unlearn")
                {
                    string name = commands[1];
                    string spell = commands[2];
                    if (heroes.ContainsKey(name))
                    {
                        if (heroes[name].Contains(spell))
                        {
                            heroes[name].Remove(spell);
                        }
                        else
                        {
                            Console.WriteLine($"{name} doesn't know {spell}.");
                        }
                        
                        
                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }

                }
            }
            Console.WriteLine("Heroes:");
            foreach (var (item, value) in heroes)
            {
                
                Console.Write($"== {item}: ");
                
                    Console.Write(string.Join(", ",value));
                
                Console.WriteLine();
            }

        }

    }
}
