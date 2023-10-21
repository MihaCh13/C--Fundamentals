using System;
using System.Collections.Generic;
using System.Linq;

//Получавате брой хора, които чакат да се качат на лифта и състоянието на лифта.
//Направете последователни опити да натоварите хората на лифта, като не превишавате 4 човека на вагон.
//Ако няма повече хора и има свободни места в лифта, изведете състоянието на лифта и съобщение "The lift has empty spots!".
//Ако има още хора, но няма достатъчно места в лифта, изведете състоянието на лифта, броя на оставащите хора в опашката и съобщение "There isn't enough space!".
//Ако всички хора са се натоварили и лифтът е пълен, изведете само състоянието на лифта.

namespace ReceiptPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            List<int> wagon = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int length = wagon.Count();
            int emptyCounter = 0;

            for (int i = 0; i < length; i++)
            {
                while (wagon[i] < 4 && people > 0)
                {
                    people--;
                    wagon[i]++;
                }

                if (wagon[i] < 4)
                {
                    emptyCounter++;
                }
            }

            if (emptyCounter > 0)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }

            Console.WriteLine(string.Join(" ", wagon));
        }
    }
}
