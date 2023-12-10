using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int num1 = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = num; i <= num1; i++)
        {
            sum += i;
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        Console.WriteLine($"Sum: {sum}");

    }
}
