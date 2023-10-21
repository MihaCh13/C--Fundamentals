//Приемате четири вида команди, докато не получите "Go Shopping!":
//"Urgent {продукт}" - добавя продукта в началото на списъка, ако вече не съществува.
//"Unnecessary {продукт}" - премахва продукта, ако съществува в списъка.
//"Correct {старПродукт} {новПродукт}" - заменя името на продукта с новото име, ако съществува.
//"Rearrange {продукт}" - изважда продукта от текущата позиция и го добавя в края на списъка.
//Показвате списъка с продукти, след като всички команди са обработени.
//Целта е да генерирате окончателния списък с покупки след обработката на командите.
using System;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceryList = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();

            string comandInput = Console.ReadLine();

            while (comandInput != "Go Shopping!")
            {
                List<string> curentComands = comandInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (curentComands[0] == "Urgent")
                {
                    if (!groceryList.Contains(curentComands[1]))
                    {
                        groceryList.Insert(0, curentComands[1]);
                    }
                }
                else if (curentComands[0] == "Unnecessary")
                {
                    if (groceryList.Contains(curentComands[1]))
                    {
                        groceryList.Remove(curentComands[1]);
                    }
                }
                else if (curentComands[0] == "Correct")
                {
                    if (groceryList.Contains(curentComands[1]))
                    {
                        int oldItemIndex = groceryList.IndexOf(curentComands[1]);

                        groceryList.Remove(curentComands[1]);
                        groceryList.Insert(oldItemIndex, curentComands[2]);

                    }
                }
                else if (curentComands[0] == "Rearrange")
                {
                    if (groceryList.Contains(curentComands[1]))
                    {
                        string item = curentComands[1];
                        groceryList.Remove(item);
                        groceryList.Add(item);

                    }
                }
                comandInput = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", groceryList));
        }
    }
}
