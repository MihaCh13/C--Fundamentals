using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        string input = Console.ReadLine();
        string[] inputValues = input.Split(' ');

        // Конвертиране на стринговите стойности в цели числа
        int[] array = new int[inputValues.Length];
        for (int i = 0; i < inputValues.Length; i++)
        {
            if (int.TryParse(inputValues[i], out int value))
            {
                array[i] = value;
            }
            else
            {
                Console.WriteLine($"Грешка при конвертиране на {inputValues[i]} в число.");
                return;
            }
        }

        // Намиране на top integers
        List<int> topIntegers = FindTopIntegers(array);

        
        foreach (var topInt in topIntegers)
        {
            Console.Write($"{topInt} ");
        }
    }

    static List<int> FindTopIntegers(int[] array)
    {
        List<int> topIntegers = new List<int>();

        int maxRight = int.MinValue;

        // Итерация от дясно наляво
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int currentNumber = array[i];

            // Ако текущото число е по-голямо от максимума отдясно, то е top integer
            if (currentNumber > maxRight)
            {
                topIntegers.Insert(0, currentNumber); // Вмъкване в началото на списъка
                maxRight = currentNumber; // Обновяване на максимума
            }
        }

        return topIntegers;
    }
}
