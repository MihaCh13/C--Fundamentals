using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>[\d]+)\|[^|$%.]*?(?<price>[0-9]+[.]?[0-9]+)?[\$]";
            string input = Console.ReadLine();
            double sum = 0;
            while (input != "end of shift")
            {
                Match currInput = Regex.Match(input, regex);
                if (currInput.Success)
                {
                    string customerName = currInput.Groups["name"].ToString();
                    string product = currInput.Groups["product"].ToString();
                    var currPrice = double.Parse(currInput.Groups["price"].ToString());
                    int currCount = int.Parse(currInput.Groups["count"].ToString());

                    double totalPrice = currCount * currPrice;
                    sum += totalPrice;
                    Console.WriteLine($"{customerName}: {product} - {totalPrice:F2}");
                }


                input = Console.ReadLine();
            }
            
            Console.WriteLine($"Total income: {sum:F2}");
        }
    }
}
