using System;

//Получавате количества храна, слама и покривки, закупени от Мери за месец (30 дни).
//Получавате теглото на гинеяския пиг (Puppy).
//Гинеяският пиг изяжда 300 грама храна на ден.
//Всеки втори ден Мери добавя 5% от останалата храна към количеството слама.
//На всеки трети ден Мери слага покривка, която е 1/3 от теглото на гинеяския пиг.
//Целта е да проверите дали количествата храна, слама и покривки са достатъчни за 30-дневния период.

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main()
        {
            double food = 1000 * double.Parse(Console.ReadLine());
            double hay = 1000 * double.Parse(Console.ReadLine());
            double cover = 1000 * double.Parse(Console.ReadLine());
            double weight = 1000 * double.Parse(Console.ReadLine());
            bool isHaveAll = true;

            weight /= 3;

            for (int i = 1; i <= 30; i++)
            {
                food -= 300;

                if (i % 2 == 0)
                {
                    hay -= food * 0.05;
                }

                if (i % 3 == 0)
                {
                    cover -= weight;
                }

                if (cover <= 0 || hay <= 0 || food <= 0)
                {
                    isHaveAll = false;
                    break;
                }
            }

            food /= 1000;
            hay /= 1000;
            cover /= 1000;

            if (isHaveAll)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");
            }
            if (!isHaveAll)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}
