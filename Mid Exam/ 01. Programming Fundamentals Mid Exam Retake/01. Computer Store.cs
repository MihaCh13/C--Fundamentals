//1. Въведете цени за компютърни части (без данъци) до получаване на команда "special" или "regular".
//2. Изчислете общите данъци, които са 20% от цените на частите.
//3. Ако някоя цена не е положителна, изведете "Invalid price!" и продължете към следващата цена.
//4. Ако общата цена (с данъци) е 0, изведете "Invalid order!" и приключете.
//5. Изберете тип на клиента (special или regular).
//6. Ако клиентът е special, приложете 10% отстъпка към общата цена с данъци.
//7. Изведете касова бележка със следния формат:
//   - "Congratulations you've just bought a new computer!"
//   - "Price without taxes: {total price without taxes}$"
//   - "Taxes: {total amount of taxes}$"
//   - "-----------"
//   - "Total price: {total price with taxes}$"

namespace ReceiptPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalPriceWithoutTaxes = 0;
            double discount = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "special" || input == "regular")
                {
                    if (input == "special")
                    {
                        discount = 0.9;
                        break;
                    }
                    else
                    {
                        discount = 1;
                        break;
                    }
                }
                else
                {
                    if (double.TryParse(input, out double price) && price > 0)
                    {
                        totalPriceWithoutTaxes += price;
                    }
                    else
                    {
                        Console.WriteLine("Invalid price!");
                    }
                }
            }

            if (totalPriceWithoutTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                double taxes = totalPriceWithoutTaxes * 0.2;
                double totalPriceWithTaxes = (totalPriceWithoutTaxes + taxes) * discount;
                
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPriceWithTaxes:F2}$");
            }
        }
    }
}
