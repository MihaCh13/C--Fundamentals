using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Regular expression pattern for validating orders
        string orderPattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";

        double totalIncome = 0;

        while (true)
        {
            string line = Console.ReadLine();
            if (line == "end of shift")
                break;

            Match match = Regex.Match(line, orderPattern);
            if (match.Success)
            {
                string customer = match.Groups["customer"].Value;
                string product = match.Groups["product"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                double price = double.Parse(match.Groups["price"].Value);
                double totalPrice = count * price;
                totalIncome += totalPrice;

                Console.WriteLine($"{customer}: {product} - {totalPrice:F2}");
            }
        }

        Console.WriteLine($"Total income: {totalIncome:F2}");
    }
}
