using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> code = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int num = code[0];
        int range = code[1];

        for (int i = 0; i < bomb.Count; i++)
        {
            if (bomb[i] == num)
            {
                int startIndex = Math.Max(0, i - range);
                int endIndex = Math.Min(bomb.Count - 1, i + range);

                bomb.RemoveRange(startIndex, endIndex - startIndex + 1);
                i = -1;  // Start over from the beginning after removing elements
            }
        }

        int sum = bomb.Sum();
        Console.WriteLine(sum);
    }
}
