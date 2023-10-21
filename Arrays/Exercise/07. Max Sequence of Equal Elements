using System;

class Program
{
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        int nums = input.Length;

        int count = 1;
        int maxCount = 1;
        int startIndex = 0;

        for (int i = 1; i < nums; i++)
        {
            if (input[i] == input[i - 1])
            {
                count++;

                if (count > maxCount)
                {
                    maxCount = count;
                    startIndex = i - maxCount + 1;
                }
            }
            else
            {
                count = 1;
            }
        }

        
        for (int i = startIndex; i < startIndex + maxCount; i++)
        {
            Console.Write(input[i] + " ");
        }
    }
}
