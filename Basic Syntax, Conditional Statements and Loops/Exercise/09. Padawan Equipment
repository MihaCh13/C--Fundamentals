using System;

class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int studentsCount = int.Parse(Console.ReadLine());
        double lightsaberPrice = double.Parse(Console.ReadLine());
        double robePrice = double.Parse(Console.ReadLine());
        double beltPrice = double.Parse(Console.ReadLine());

        double totalLightsaberPrice = Math.Ceiling(studentsCount * 1.1) * lightsaberPrice;
        double totalRobePrice = studentsCount * robePrice;
        double totalBeltPrice = (studentsCount - studentsCount / 6) * beltPrice;

        double totalPrice = totalLightsaberPrice + totalRobePrice + totalBeltPrice;

        if (totalPrice <= budget)
        {
            Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
        }
        else
        {
            double neededMoney = totalPrice - budget;
            Console.WriteLine($"John will need {neededMoney:F2}lv more.");
        }
    }
}
