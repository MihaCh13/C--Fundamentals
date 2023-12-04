using System;
using System.Collections.Generic;
using System.Linq;

class RaceProgram
{
    static void Main()
    {
        // Четене на участници и инициализация на списъка с техните имена
        List<string> participants = Console.ReadLine()
            .Split(", ")
            .ToList();

        // Речник, в който ще съхраняваме информация за разстоянието на всеки участник
        Dictionary<string, int> racerDistances = new Dictionary<string, int>();

        // Цикъл за обработка на информация за състезанието
        while (true)
        {
            // Четене на входната информация за текущия участник
            string input = Console.ReadLine();

            // Проверка за край на въвеждането на информация
            if (input == "end of race")
            {
                break;
            }

            // Извличане на името на участника
            string racerName = new string(input.Where(char.IsLetter).ToArray());

            // Извличане на разстоянието, като се сумират цифрите
            int distance = input
                .Where(char.IsDigit)
                .Select(c => int.Parse(c.ToString()))
                .Sum();

            // Проверка дали участникът е в списъка с участници
            if (participants.Contains(racerName))
            {
                // Инициализация на разстоянието на участника, ако все още не е в речника
                if (!racerDistances.ContainsKey(racerName))
                {
                    racerDistances[racerName] = 0;
                }

                // Добавяне на изминатото разстояние към общото разстояние на участника
                racerDistances[racerName] += distance;
            }
        }

        // Сортиране на участниците по изминато разстояние и извеждане на топ 3
        var sortedRacers = racerDistances
            .OrderByDescending(x => x.Value)
            .Take(3)
            .Select((r, i) => $"{GetPlace(i + 1)} place: {r.Key}")
            .ToList();

        // Извеждане на резултата
        Console.WriteLine(string.Join(Environment.NewLine, sortedRacers));
    }

    // Получаване на текстово представяне на мястото (1st, 2nd, 3rd и т.н.)
    static string GetPlace(int place)
    {
        switch (place)
        {
            case 1:
                return "1st";
            case 2:
                return "2nd";
            case 3:
                return "3rd";
            default:
                return $"{place}th";
        }
    }
}
