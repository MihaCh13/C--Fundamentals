using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");

        int[] array = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            if (int.TryParse(input[i], out int value))
            {
                array[i] = value;
            }
            else
            {
                Console.WriteLine(input[i]);
                return;
            }
        }

        int index = FindElementWithEqualSums(array);

        if (index != -1)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("no");
        }
    }

    static int FindElementWithEqualSums(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (SumLeft(array, i) == SumRight(array, i))
            {
                return i;
            }
        }

        return -1;
    }

    static int SumLeft(int[] array, int index)
    {
        int sum = 0;
        for (int i = 0; i < index; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static int SumRight(int[] array, int index)
    {
        int sum = 0;
        for (int i = index + 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
}
