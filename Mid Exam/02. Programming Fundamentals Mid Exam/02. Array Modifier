using System;
using System.Collections.Generic;
using System.Linq;

//1. Получавате начален масив от цели числа.
//2. Следват редове с команди, докато не получите командата "end".
//3. Командите могат да бъдат:
//   - "swap {index1} {index2}" - разменя два елемента в масива на позиции index1 и index2.
//   - "multiply {index1} {index2}" - умножава елемент на позиция index1 по елемент на позиция index2 и записва резултата на позиция index1.
//   - "decrease" - намалява всички елементи в масива с 1.
//4. Отпечатайте резултата след изпълнението на всички команди, като елементите са разделени с ", ".

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        while (true)
        {
            List<string> command = Console.ReadLine().Split(' ').ToList();

            if (command[0] == "end")
            {
                break;
            }
            else if (command[0] == "swap" && command.Count == 3)
            {
                int index1 = int.Parse(command[1]);
                int index2 = int.Parse(command[2]);
                if (IsValidIndex(index1, numbers.Count) && IsValidIndex(index2, numbers.Count))
                {
                    Swap(numbers, index1, index2);
                }
                else
                {
                    Console.WriteLine("Invalid swap indices.");
                }
            }
            else if (command[0] == "multiply" && command.Count == 3)
            {
                int index1 = int.Parse(command[1]);
                int index2 = int.Parse(command[2]);
                if (IsValidIndex(index1, numbers.Count) && IsValidIndex(index2, numbers.Count))
                {
                    Multiply(numbers, index1, index2);
                }
                else
                {
                    Console.WriteLine("Invalid multiply indices.");
                }
            }
            else if (command[0] == "decrease")
            {
                Decrease(numbers);
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }

        Console.WriteLine(string.Join(", ", numbers));
    }

    private static bool IsValidIndex(int index, int length)
    {
        return index >= 0 && index < length;
    }

    private static void Swap(List<int> list, int index1, int index2)
    {
        int temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }

    private static void Multiply(List<int> list, int index1, int index2)
    {
        list[index1] = list[index1] * list[index2];
    }

    private static void Decrease(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i] - 1;
        }
    }
}
