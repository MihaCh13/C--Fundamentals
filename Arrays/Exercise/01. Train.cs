using System;
 
class Program
{
    static void Main()
    {
        int wagons = int.Parse(Console.ReadLine());
        int total = 0;

        for (int i = 0; i < wagons; i++)
        {
            int people = int.Parse(Console.ReadLine());
            total += people;

            // Print the number of passengers in the current wagon on the same line
            Console.Write($"{people} ");
        }

        // Print a new line before printing the total number of passengers
        Console.WriteLine();

        // Print the total number of passengers on the train
        Console.WriteLine($"{total}");
    }
}
