using System;

class Program
{
    static void Main()
    {
        int lostGamesCount = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        int trashedHeadsets = lostGamesCount / 2;
        int trashedMouses = lostGamesCount / 3;
        int trashedKeyboards = trashedMouses / 2; // Second time when he trashes his mouse, he trashes his keyboard
        int trashedDisplays = trashedKeyboards / 2; // When he trashes his keyboard, he also trashes his display

        double expenses = trashedHeadsets * headsetPrice +
                          trashedMouses * mousePrice +
                          trashedKeyboards * keyboardPrice +
                          trashedDisplays * displayPrice;

        Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
    }
}
