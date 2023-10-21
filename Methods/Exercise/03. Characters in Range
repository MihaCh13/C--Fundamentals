using System;

class Program
{
    static void Main()
    {
        PrintCharsBetween();
    }

    static void PrintCharsBetween()
    {
        int beginCharCode = Console.Read();
        char beginChar = (char)beginCharCode;

        // Прескачаме новия ред след прочитането на първия символ
        Console.ReadLine();

        int lastCharCode = Console.Read();
        char lastChar = (char)lastCharCode;

        // Ако ASCII стойността на втория символ е по-малка от първия, разменяме ги
        if (lastChar < beginChar)
        {
            char temp = beginChar;
            beginChar = lastChar;
            lastChar = temp;
        }

        // Използваме цикъл for за по-четимост
        for (char i = (char)(beginChar + 1); i < lastChar; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}
