using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double pi = Math.PI;
        double maxVolume = double.MinValue;
        string maxModel = "";

        for (int i = 0; i < n; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = pi * Math.Pow(radius, 2) * height;

            if (volume > maxVolume)
            {
                maxVolume = volume;
                maxModel = model;
            }
        }

        Console.WriteLine(maxModel);
    }
}
