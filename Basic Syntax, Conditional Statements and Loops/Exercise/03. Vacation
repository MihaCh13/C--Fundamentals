using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int people = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        string day = Console.ReadLine();
        double price = 0.0;
        double discount = 0.0;

        if (type == "Students")
        {
            if (day == "Friday")
            {
                price = people * 8.45;
            }
            else if (day == "Saturday")
            {
                price = people * 9.80;
            }
            else if (day == "Sunday")
            {
                price = people * 10.46;
            }
            if (people >= 30)
            {
                price = price * 0.85;
            }
        }
        else if (type == "Business")
        {
            if (day == "Friday")
            {
                price = people * 10.90;
                discount = 10 * 10.90;
            }
            else if (day == "Saturday")
            {
                price = people * 15.60;
                discount = 10 * 15.60;
            }
            else if (day == "Sunday")
            {
                price = people * 16;
                discount = 10 * 16;
            }
            if (people >= 100)
            {
                price = price - discount;
            }
        }
        else if (type == "Regular")
        {
            if (day == "Friday")
            {
                price = people * 15;
            }
            else if (day == "Saturday")
            {
                price = people * 20;
            }
            else if (day == "Sunday")
            {
                price = people * 22.50;
            }
            if (10 <= people && people <= 20)
            {
                price = price * 0.95;
            }
        }
        Console.WriteLine($"Total price: {price:F2}");
    }
}
