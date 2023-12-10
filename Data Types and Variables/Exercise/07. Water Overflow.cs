using System;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int numLines = int.Parse(Console.ReadLine());
        int capacity = 255;
        int counter = 0;
        for (int i = 0; i < numLines; i++)
        {
            int liters = int.Parse(Console.ReadLine());
            counter += liters;
            if (capacity < counter)
            {
                Console.WriteLine("Insufficient capacity!");
                counter -= liters;
            }
        }
        Console.WriteLine(counter);

    }
}
    
