using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var products = new Dictionary<string, Product>();

        while (true)
        {
            string[] input = Console.ReadLine().Split(" ");
            string productName = input[0];

            if (productName == "buy")
            {
                break;
            }

            double price = double.Parse(input[1]);
            int quantity = int.Parse(input[2]);

            if (!products.ContainsKey(productName))
            {
                products.Add(productName, new Product { Price = price, Quantity = quantity });
            }
            else
            {
                products[productName].Quantity += quantity;
                if (products[productName].Price != price)
                {
                    products[productName].Price = price;
                }
            }
        }

        foreach (var kvp in products)
        {
            string productName = kvp.Key;
            double totalPrice = kvp.Value.Price * kvp.Value.Quantity;
            Console.WriteLine($"{productName} -> {totalPrice:f2}");
        }
    }
}

class Product
{
    public double Price { get; set; }
    public int Quantity { get; set; }
}
