using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Проверка за валидност на входа
        if (n <= 0 || n > 26)
        {
            Console.WriteLine("Invalid number n. Enter a positive number up to 26.");
            return;
        }

        // Вложени цикли за обхождане на всички тройки от първите n малки латински букви
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    char firstLetter = (char)('a' + i);
                    char secondLetter = (char)('a' + j);
                    char thirdLetter = (char)('a' + k);

                    // Извеждане на тройката
                    Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                }
            }
        }
    }
}
