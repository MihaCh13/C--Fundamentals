using System;
using System.Collections.Generic;
using System.Linq;

//Получавате последователност от цели числа.
//Намирате средната стойност на всички числа в последователността.
//Намирате топ 5 числа, по-големи от средната стойност, и ги сортирате в низходящ ред.
//Отпечатвате тези числа на един ред, разделени с интервал.
//Ако няма поне 5 числа, по-големи от средната стойност, отпечатайте "No".

class Program
{
    static void Main(string[] args)
    {
        WorkingDay();
    }

    static void WorkingDay()
    {
        List<int> masiv = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int average = masiv.Sum() / masiv.Count();
        List<int> maxValues = new List<int>();

        for (int i = 0; i < masiv.Count; i++)
        {
            if (masiv[i] > average)
            {
                maxValues.Add(masiv[i]);
            }
        }

        if (maxValues.Count >= 6)
        {
            maxValues.Sort();
            maxValues.Reverse();

            // excess = maxValues.Count - 5
            // 9 8 7 6 5 4 3 2 1
            // 9 8 7 6 5 
            // 0 1 2 3 4
            for (int j = maxValues.Count - 1; j>= 5; j--)
            {
                maxValues.RemoveAt(j);
            }
        }
        else
        {
            maxValues.Sort();
            maxValues.Reverse();
        }

        if (maxValues.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(string.Join(" ", maxValues));
        }
    }
}
