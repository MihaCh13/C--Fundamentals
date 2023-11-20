using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._StudentAademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();
            Dictionary<string, decimal> averageGrades = new Dictionary<string, decimal>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string Name = Console.ReadLine();
                decimal Grade = decimal.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(Name))
                {
                    studentsGrades.Add(Name, new List<decimal>());
                    studentsGrades[Name].Add(Grade);
                }
                else
                {
                    studentsGrades[Name].Add(Grade);
                }
            }

            foreach (var grades in studentsGrades)
            { 
                averageGrades.Add(grades.Key, grades.Value.Average());
            }

            foreach (var grade in averageGrades)
            {
                if (grade.Value < 4.50m)
                {
                    averageGrades.Remove(grade.Key);
                }
            }

            averageGrades = averageGrades.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var grad in averageGrades)
            {
                Console.WriteLine($"{grad.Key} -> {grad.Value:f2}");
            }

        }
    }
}
