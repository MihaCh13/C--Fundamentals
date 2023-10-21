using System;

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        double result = CalculateFactorial(num1) / (double)CalculateFactorial(num2);

        Console.WriteLine($"{result:F2}");
    }

    static long CalculateFactorial(int n)
    {
        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
