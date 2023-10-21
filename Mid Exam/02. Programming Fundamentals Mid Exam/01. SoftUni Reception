using System;
using System.Collections.Generic;
using System.Linq;

//1. Получавате ефективността на тримата служители - колко ученици може всеки да обслужи за 1 час.
//2. Получавате общия брой на учениците, които трябва да бъдат обслужени.
//3. През всеки четвърт час служителите правят почивка за 1 час.
//4. Изчислете времето, нужно за обслужване на всички ученици.
//5. Изведете резултата във формата "Time needed: {time}h."

class Program
{
    static void Main(string[] args)
    {
        WorkingDay();
    }
    static void WorkingDay()
    {
        int helper1 = int.Parse(Console.ReadLine());
        int helper2 = int.Parse(Console.ReadLine());
        int helper3 = int.Parse(Console.ReadLine());
        int sumHelper = helper1 + helper2 + helper3;
        int time = 0;
        int students = int.Parse(Console.ReadLine());
        while (students != 0)
        {
            for (int i = 0; i < 3; i++)
            {
                if (students >= sumHelper )
                {
                    students -= sumHelper;
                    time++;
                }
                else if (students > 0)
                {
                    students = 0;
                    time++;
                    break;
                }

            }
            if (students != 0) { time++; }

        }
        Console.WriteLine($"Time needed: {time}h.");
    }
}
