using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Създаваме списък за съхранение на имената на закупените мебели
        List<string> boughtFurniture = new List<string>();
        // Променлива за съхранение на общата сума, която сме харчили
        double totalMoneySpent = 0;

        // Четем вход от потребителя докато не получим ред "Purchase"
        while (true)
        {
            string input = Console.ReadLine();

            // Проверка дали въведената информация е "Purchase" и ако е, излизаме от цикъла
            if (input == "Purchase")
            {
                break;
            }

            // Регулярен израз за извличане на информацията за мебелите от входа
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>[0-9]+(\.[0-9]+)?)!(?<quantity>[0-9]+)";
            // Използваме Regex.Match, за да проверим дали входа отговаря на регулярния израз
            Match match = Regex.Match(input, pattern);

            // Проверка дали регулярният израз съвпада с входната информация
            if (match.Success)
            {
                // Извличане на информацията от съвпадението
                string furnitureName = match.Groups["name"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);

                // Изчисляване на общата цена за текущата мебел
                double totalPrice = price * quantity;
                // Добавяне на мебелта към списъка
                boughtFurniture.Add(furnitureName);
                // Добавяне на цената за текущата мебел към общата сума
                totalMoneySpent += totalPrice;
            }
        }

        // Извеждане на закупените мебели на нов ред за всяка от тях
        Console.WriteLine("Bought furniture:");
        foreach (string furniture in boughtFurniture)
        {
            Console.WriteLine(furniture);
        }

        // Извеждане на общата сума, която сме харчили, форматирана до втория знак след десетичната запетая
        Console.WriteLine($"Total money spend: {totalMoneySpent:f2}");
    }
}
