using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (firstHand.Count > 0 && secondHand.Count > 0)
        {
            int firstCard = firstHand[0];
            int secondCard = secondHand[0];

            if (firstCard > secondCard)
            {
                // First player wins
                firstHand.RemoveAt(0);
                secondHand.RemoveAt(0);
                firstHand.Add(firstCard);
                firstHand.Add(secondCard);
            }
            else if (firstCard < secondCard)
            {
                // Second player wins
                firstHand.RemoveAt(0);
                secondHand.RemoveAt(0);
                secondHand.Add(secondCard);
                secondHand.Add(firstCard);
            }
            else
            {
                // Draw, remove both cards
                firstHand.RemoveAt(0);
                secondHand.RemoveAt(0);
            }
        }

        if (firstHand.Count > 0)
        {
            Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
        }
        else
        {
            Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
        }
    }
}
