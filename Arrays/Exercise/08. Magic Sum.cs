using System;

class Program
{
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        int nums = input.Length;
        int targetSum = int.Parse(Console.ReadLine());

        for (int i = 0; i < nums - 1; i++)
        {
            for (int m = i + 1; m < nums; m++)  // Променена грешка тук
            {
                int sum = input[i] + input[m];
                if (sum == targetSum)
                {
                    Console.WriteLine(input[i] + " " + input[m]);
                }
            }
        }
    }
}
