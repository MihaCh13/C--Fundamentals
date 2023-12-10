using System;
using System.Collections.Generic;
using System.Linq;

//Получавате начална енергия.
//След това получавате разстояния до врагове, които трябва да преодолеете.
//Ако имате достатъчно енергия, за да достигнете до враг, спечелвате битка и губите енергия.
//Ако останете без енергия или получите командата "End of battle", програмата приключва.
//Всяка трета спечелена битка ви увеличава енергията с текущия брой спечелени битки.
//На края отпечатайте броя на спечелените битки и останалата енергия.

class Program
{
    static void Main(string[] args)
    {
        WorkingDay();
    }

    static void WorkingDay()
    {
        int energy = int.Parse(Console.ReadLine());
        int counter = 0;

        while (true)
        {
            string command = Console.ReadLine();
            
            if (command == "End of battle")
            {
                break;
            }

            int distance = int.Parse(command);
            counter++;

            if (energy < distance)
            {
                Console.WriteLine($"Not enough energy! Game ends with {counter - 1} won battles and {energy} energy");
                return;
            }

            energy -= distance;

            if (counter % 3 == 0)
            {
                energy += counter;
            }
        }

        Console.WriteLine($"Won battles: {counter}. Energy left: {energy}");
    }
}
