using System;
using System.Collections.Generic; 
using System.Linq;

//1. Получавате начална поредица от елементи.
//2. Поредицата съдържа двойки идентични елементи.
//3. Приемате цели числа (индекси) до командата "end".
//4. Ако играчът въведе два индекса, които не съвпадат или са извън границите на поредицата, добавете нова двойка елементи в средата на поредицата.
//5. Ако играчът открие две съвпадащи елемента, ги премахнете и изведете съобщение "Congrats! You have found matching elements - {element}!".
//6. Ако играчът открие два различни елемента, изведете "Try again!".
//7. Ако играчът намери всички съвпадащи елементи преди да получи "end", изведете "You have won in {number of moves until now} turns!".
//8. Ако играчът получи "end" преди да открие всички съвпадащи елементи, изведете "Sorry you lose :(" и текущото състояние на поредицата.

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main()
        {
            // Четене на входната последователност от елементи
            List<string> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            // Извикване на функцията за стартиране на играта
            PlayMemoryGame(list);
        }

        static void PlayMemoryGame(List<string> list)
        {
            // Инициализация на брояч за ходове
            int turnCount = 0;

            // Безкраен цикъл за въвеждане на команди
            while (true)
            {
                // Въвеждане на команда от играча
                string command = Console.ReadLine();

                // Проверка за край на играта
                if (command == "end")
                {
                    break;
                }

                // Преобразуване на входа в списък от индекси
                List<int> indexCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToList();

                // Увеличаване на брояча на ходове
                turnCount++;

                // Проверка за валидност на входа
                if (IsValidInput(indexCommand, list))
                {
                    // Проверка за съвпадение на двата елемента
                    if (list[indexCommand[0]] == list[indexCommand[1]])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {list[indexCommand[0]]}!");

                        // Изтриване на съвпадналите елементи от списъка
                        int firstIndex = Math.Min(indexCommand[0], indexCommand[1]);
                        int secondIndex = Math.Max(indexCommand[0], indexCommand[1]);

                        list.RemoveAt(secondIndex);
                        list.RemoveAt(firstIndex);
                    }
                    else
                    {
                        // Съобщение при неподходящи елементи
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    // Добавяне на допълнителни елементи и съобщение за невалиден вход
                    InsertAdditionalElements(list, turnCount);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                // Проверка за победа
                if (list.Count == 0)
                {
                    Console.WriteLine($"You have won in {turnCount} turns!");
                    return;
                }
            }

            // Съобщение за загуба и изписване на текущото състояние на списъка
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", list));
        }

        // Проверка за валидност на входните индекси
        static bool IsValidInput(List<int> indexes, List<string> list)
        {
            return indexes.All(i => i >= 0 && i < list.Count) && indexes[0] != indexes[1];
        }

        // Добавяне на допълнителни елементи към списъка
        static void InsertAdditionalElements(List<string> list, int turnCount)
        {
            list.Insert(list.Count / 2, "-" + turnCount + "a");
            list.Insert(list.Count / 2, "-" + turnCount + "a");
        }
    }
}
