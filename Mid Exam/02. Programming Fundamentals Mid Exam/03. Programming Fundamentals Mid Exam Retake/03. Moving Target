using System;
using System.Collections.Generic;
using System.Linq;

//1. Получавате начална последователност от мишени с техните цели числови стойности, разделени със символ за интервал.
//2. Получавате команди за манипулиране на мишените, докато не получите командата "End".
//3. Възможни са три вида команди:
//   - "Shoot {index} {power}" - уцелете мишена на даден индекс и намалете стойността ѝ с дадена сила. Мишената се премахва, ако стойността й стане 0.
//   - "Add {index} {value}" - вмъкнете мишена с дадена стойност на определен индекс. Ако индексът е невалиден, изведете "Invalid placement!".
//   - "Strike {index} {radius}" - премахнете мишена на даден индекс и тези преди и след него в радиус, ако са валидни. В противен случай изведете "Strike missed!".
//4. Когато получите "End", отпечатайте текущата последователност от мишени в съответния формат.

class Program
{
    static void Main(string[] args)
    {
        HandleTargets();
    }

    static void HandleTargets()
    {
        List<int> targets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        string command = Console.ReadLine();

        while (command != "End")
        {
            List<string> commandParts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            if (commandParts[0] == "Shoot")
            {
                ShootTarget(commandParts, targets);
            }
            else if (commandParts[0] == "Add")
            {
                AddTarget(commandParts, targets);
            }
            else if (commandParts[0] == "Strike")
            {
                StrikeTargets(commandParts, targets);
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join("|", targets));
    }

    static void ShootTarget(List<string> command, List<int> targets)
    {
        int index = int.Parse(command[1]);
        int power = int.Parse(command[2]);

        if (IsValidIndex(index, targets) && targets[index] > 0)
        {
            targets[index] = Math.Max(0, targets[index] - power);

            if (targets[index] == 0)
            {
                targets.RemoveAt(index);
            }
        }
    }

    static void AddTarget(List<string> command, List<int> targets)
    {
        int index = int.Parse(command[1]);
        int value = int.Parse(command[2]);

        if (IsValidIndex(index, targets))
        {
            targets.Insert(index, value);
        }
        else
        {
            Console.WriteLine("Invalid placement!");
        }
    }

    static void StrikeTargets(List<string> command, List<int> targets)
    {
        int index = int.Parse(command[1]);
        int radius = int.Parse(command[2]);
        int valid = 0;

        if (index < 0 || index >= targets.Count)
        {
            valid++;
        }

        for (int i = 1; i <= radius; i++)
        {
            if (index - i < 0 || index + i > targets.Count - 1)
            {
                valid++;
            }
        }

        if (valid > 0)
        {
            Console.WriteLine("Strike missed!");
        }
        else
        {
            int startIndex = Math.Max(0, index - radius);
            int endIndex = Math.Min(targets.Count - 1, index + radius);
            targets.RemoveRange(startIndex, endIndex - startIndex + 1);
        }
    }

    static bool IsValidIndex(int index, List<int> targets)
    {
        return index >= 0 && index < targets.Count;
    }

    static bool IsStrikeValid(int index, int radius, int targetsCount)
    {
        return index >= 0 && index < targetsCount && radius >= 0;
    }
}
