using System;
using System.Collections.Generic;

namespace _03._Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> heroeInfo = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] currentCommand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = currentCommand[1];
                switch (currentCommand[0])
                {
                    case "Enroll":

                        if (!heroeInfo.ContainsKey(heroName))
                        {
                            heroeInfo.Add(heroName, new List<string>());
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} is already enrolled.");
                        }

                        break;
                    case "Learn":
                        string spellName = currentCommand[2];

                        if (!heroeInfo.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else
                        {
                            if (heroeInfo[heroName].Contains(spellName))
                            {
                                Console.WriteLine($"{heroName} has already learnt {spellName}.");
                            }
                            else
                            {
                                heroeInfo[heroName].Add(spellName);
                            }
                        }

                        break;
                    case "Unlearn":

                        string pellNameToUnlearn = currentCommand[2];
                        if (!heroeInfo.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else
                        {
                            if (!heroeInfo[heroName].Contains(pellNameToUnlearn))
                            {
                                Console.WriteLine($"{heroName} doesn't know {pellNameToUnlearn}.");
                            }
                            else
                            {
                                heroeInfo[heroName].Remove(pellNameToUnlearn);
                            }
                        }

                        break;


                }


                input = Console.ReadLine();
            }

            Console.WriteLine("Heroes:");

            foreach (var heroe in heroeInfo)
            {            
                Console.WriteLine($"== {heroe.Key}: {String.Join(", ", heroe.Value)}");             
            }
        }
    }
}
