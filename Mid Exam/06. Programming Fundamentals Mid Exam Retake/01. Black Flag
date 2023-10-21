using System;

class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        int plunderPerDay = int.Parse(Console.ReadLine());
        double expectedPlunder = double.Parse(Console.ReadLine());

        double totalPlunder = 0;
        int attackCount = 0;

        for (int day = 1; day <= days; day++)
        {
            totalPlunder += plunderPerDay;

            if (day % 3 == 0)
            {
                totalPlunder += plunderPerDay * 0.5;
            }

            if (day % 5 == 0)
            {
                double lostPlunder = totalPlunder * 0.3;
                totalPlunder -= lostPlunder;
            }
        }

        if (totalPlunder >= expectedPlunder)
        {
            Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
        }
        else
        {
            double percentage = (totalPlunder / expectedPlunder) * 100;
            Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
        }
    }
}
