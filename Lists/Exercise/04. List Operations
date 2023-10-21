using System;
using System.Collections.Generic;
using System.Linq;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                
                if (command.Count < 2 || command[0] == "End")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    string addNum = command[1];
                    numbers.Add(addNum);
                }
                else if (command[0] == "Insert")
                {
                    string insertNum = command[1];
                    int insertIndex = int.Parse(command[2]);
                    if (insertIndex >= 0 && insertIndex <= numbers.Count)
                    {
                        numbers.Insert(insertIndex, insertNum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[1] == "left")
                {
                    int leftNum = int.Parse(command[2]) % numbers.Count;
                    RotateLeft(numbers, leftNum);
                }
                else if (command[1] == "right")
                {
                    int rightNum = int.Parse(command[2]) % numbers.Count;
                    RotateRight(numbers, rightNum);
                }
                else if (command[0] == "Remove")
                {
                    int removeNumber = int.Parse(command[1]);

                    if (removeNumber >= 0 && removeNumber < numbers.Count)
                    {
                        numbers.RemoveAt(removeNumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void RotateLeft(List<string> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                string firstNumber = list[0];
                list.RemoveAt(0);
                list.Add(firstNumber);
            }
        }

        private static void RotateRight(List<string> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                string lastNumber = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, lastNumber);
            }
        }
    }
}
