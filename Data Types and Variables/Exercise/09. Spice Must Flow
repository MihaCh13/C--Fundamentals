using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Въвеждане на началния добив на източника
        int initialYield = int.Parse(Console.ReadLine());

        // Променливи за проследяване на броя дни и общия добив
        int daysWorked = 0;
        int totalSpice = 0;

        // Работа на източника, докато добивът е най-малко 100
        while (initialYield >= 100)
        {
            // Добавяне на текущия добив към общия добив
            totalSpice += initialYield;

            // Изчисляване на новия добив за следващия ден
            initialYield -= 10;

            // Работниците консумират 26 подправки в края на смяната
            totalSpice -= 26;

            // Увеличаване на броя дни
            daysWorked++;
        }

        // Ако общият добив е по-малък от 26, тогава работниците не могат да консумират повече подправки, отколкото има в склада
        if (totalSpice < 26)
        {
            totalSpice = 0;
        }
        else
        {
            // Работниците консумират още 26 подправки след като мината е била изчерпана
            totalSpice -= 26;
        }

        // Извеждане на резултата
        Console.WriteLine(daysWorked);
        Console.WriteLine(totalSpice);
    }
}
