using System;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int sumOfDigits = CalculateSumOfDigits(number);
        Console.WriteLine(sumOfDigits);
    }
    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}
    
