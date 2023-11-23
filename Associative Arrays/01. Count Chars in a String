using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var counts = new Dictionary<char, int>();
        
        // Четем низ от конзолата
        string input = Console.ReadLine();

        // Превръщаме низа в масив от символи
        char[] chars = input.ToCharArray();

        // Обхождаме всеки символ от масива
        foreach (char ch in chars)
        {
            // Пропускаме интервалите
            if (ch == ' ')
            {
                continue;
            }

            // Проверяваме дали символът вече се съдържа в речника
            if (!counts.ContainsKey(ch))
            {
                // Ако не се съдържа, добавяме го със стойност 1
                counts.Add(ch, 1);
            }
            else
            {
                // Ако се съдържа, увеличаваме брояча с 1
                counts[ch]++;
            }
        }

        // Извеждаме броя на срещанията за всеки символ
        foreach (var kvp in counts)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}
