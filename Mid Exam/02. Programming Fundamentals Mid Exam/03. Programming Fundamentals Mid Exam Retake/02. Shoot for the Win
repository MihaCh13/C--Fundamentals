using System;

//Получавате последователност от цели числа, представляващи целилочислени стойности на мишените.
//След това получавате индекси, на които ще стреляте, докато не получите командата "End".
//При всяко стрелба на мишена:
//Стойността на съответната мишена става -1, като се счита за уцелена.
//Всички други мишени с по-голяма стойност от текущата уцелена мишена намаляват съответната стойност на уцелената мишена.
//Всички други мишени с по-малка или равна стойност на уцелената мишена увеличават съответната стойност на уцелената мишена.
//Не можете да стреляте вече уцелени мишени и да променяте техните стойности.
//Когато получите "End", отпечатайте текущите мишени и броя на уцелените мишени.

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int targetsCount = 0;

            string comands = Console.ReadLine();

            while (comands != "End")
            {
                int curentIndex = int.Parse(comands);

                if (curentIndex >= 0 && curentIndex < targets.Count)
                {
                    targetsCount++;
                    int numberOnTheIndex = targets[curentIndex];
                    targets[curentIndex] = -1;

                    for (int i = 0; i < targets.Count; i++)
                    {
                        if (targets[i] == -1)
                        {

                        }
                        else
                        {
                            
                            if (targets[i] > numberOnTheIndex)
                            {
                                targets[i] -= numberOnTheIndex;
                            }
                            else 
                            {
                                targets[i] += numberOnTheIndex;
                            }

                        }
                    }
                }

                comands = Console.ReadLine();
            }
            Console.Write($"Shot targets: {targetsCount} -> ");
            Console.WriteLine(string.Join(" ", targets));
        }
    }
}
