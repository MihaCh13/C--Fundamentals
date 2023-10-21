using System;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        double coin = 0.0;
        double counter = 0.0;
        string strC = coin.ToString();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Start")
            {
                break; // Излизаме от цикъла, ако въведеният текст е "Start"
            }

            coin = double.Parse(input);
            strC = coin.ToString();

            if (coin != 2 && coin != 1 && coin != 0.5 && coin != 0.2 && coin != 0.1 && coin != 0.05 && coin != 0.02 && coin != 0.01)
            {
                Console.WriteLine($"Cannot accept {coin}");
                counter -= coin;
            }
            else
            {
                counter += coin;
            }
        }


        string food = Console.ReadLine();

        while (food != "End")
        {
            double Nuts = 2.0;
            double Water = 0.7;
            double Crisps = 1.5;
            double Soda = 0.8;
            double Coke = 1.0;

            if (food != "Nuts" && food != "Water" && food != "Crisps" && food != "Soda" && food != "Coke")
            {
                Console.WriteLine("Invalid product");
            }
            else
            {
                double price = 0.0;

                switch (food)
                {
                    case "Nuts":
                        price = Nuts;
                        break;
                    case "Water":
                        price = Water;
                        break;
                    case "Crisps":
                        price = Crisps;
                        break;
                    case "Soda":
                        price = Soda;
                        break;
                    case "Coke":
                        price = Coke;
                        break;
                }

                if (counter < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    string lowerCaseString = food.ToLower();
                    Console.WriteLine($"Purchased {lowerCaseString}");
                    counter -= price;
                }
            }
            ;
            food = Console.ReadLine();
        }

        Console.WriteLine($"Change: {counter:F2}");
    }
}
