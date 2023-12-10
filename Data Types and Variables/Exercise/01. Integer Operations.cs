using System;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int firstOperation = n1 + n2;
        int secondOperation = firstOperation / n3;
        int thirdOperation = secondOperation * n4;
        Console.WriteLine(thirdOperation);

    }
}
