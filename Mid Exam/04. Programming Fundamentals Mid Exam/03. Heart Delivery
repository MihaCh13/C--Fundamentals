//На първия ред ще получите низ с четни цели числа, разделени с '@'.
//След това ще последват команди за скок до получаването на "Love!".
//Купид започва от първия дом и скача с определена дължина. Всеки дом се нуждае от определен брой сърца. С всяко намаление на броя сърца с 2, проверете дали е станал 0 и ако да, отпечатайте "Place {индекс} has Valentine's day.".
//Ако Купид скача вече посетен дом (дом със сърца 0), отпечатайте "Place {индекс} already had Valentine's day."
//На края отпечатайте последната позиция на Купид и резултата:
//Ако всички домове са отпразнували, отпечатайте "Mission was successful."
//Ако има недостъпени домове, отпечатайте "Cupid has failed {брой на недостъпните домове} places."

using System;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> houseHerds = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int curentHouse = 0;

            string comandInput = Console.ReadLine();

            while (comandInput != "Love!")
            {
                List<string> helper = comandInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                int jumpIndex = int.Parse(helper[1]);
                if (curentHouse + jumpIndex < houseHerds.Count)
                {
                    curentHouse += jumpIndex;
                    if (houseHerds[curentHouse] != 0)
                    {
                        houseHerds[curentHouse] -= 2;

                        if (houseHerds[curentHouse] == 0)
                        {
                            Console.WriteLine($"Place {curentHouse} has Valentine's day.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Place {curentHouse} already had Valentine's day.");
                    }
                }
                else
                {
                    curentHouse = 0;

                    if (houseHerds[0] != 0)
                    {
                        houseHerds[0] -= 2;

                        if (houseHerds[0] == 0)
                        {
                            Console.WriteLine($"Place {curentHouse} has Valentine's day.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Place {curentHouse} already had Valentine's day.");
                    }
                }
                comandInput = Console.ReadLine();
            }

            if (houseHerds.Sum() == 0)
            {
                Console.WriteLine($"Cupid's last position was {curentHouse}.");
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid's last position was {curentHouse}.");
                curentHouse = 0;

                for (int i = 0; i < houseHerds.Count; i++)
                {
                    if (houseHerds[i] != 0)
                    {
                        curentHouse++;
                    }
                }
                Console.WriteLine($"Cupid has failed {curentHouse} places.");
            }
        }
    }
}
