using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double totalPrice = 0;

        int i = 0;
        while (i < n)
        {
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsulesCount = int.Parse(Console.ReadLine());

            double currentOrderPrice = (days * capsulesCount) * pricePerCapsule;
            Console.WriteLine($"The price for the coffee is: ${currentOrderPrice:F2}");

            totalPrice += currentOrderPrice;
            i++;
        }

        Console.WriteLine($"Total: ${totalPrice:F2}");
    }
}
