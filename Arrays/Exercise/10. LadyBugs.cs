using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[] ladybugIndexes = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Where(index => index >= 0 && index < fieldSize)
            .ToArray();

        int[] field = new int[fieldSize];

        foreach (var index in ladybugIndexes)
        {
            field[index] = 1;
        }

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] cmdArgs = command.Split();
            int ladybugIndex = int.Parse(cmdArgs[0]);
            string direction = cmdArgs[1];
            int flyLength = int.Parse(cmdArgs[2]);

            if (ladybugIndex < 0 || ladybugIndex >= fieldSize || field[ladybugIndex] == 0)
            {
                // Skip invalid commands
                continue;
            }

            field[ladybugIndex] = 0; // The ladybug leaves its current position

            while (true)
            {
                if (direction == "right")
                {
                    ladybugIndex += flyLength;
                }
                else if (direction == "left")
                {
                    ladybugIndex -= flyLength;
                }

                if (ladybugIndex < 0 || ladybugIndex >= fieldSize)
                {
                    // The ladybug flew out of the field
                    break;
                }

                if (field[ladybugIndex] == 0)
                {
                    // The ladybug lands on an empty cell
                    field[ladybugIndex] = 1;
                    break;
                }
            }
        }

        // Print the final field
        Console.WriteLine(string.Join(" ", field));
    }
}
