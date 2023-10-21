using System;

//Първо въведете броя на студентите, броя на лекциите и допълнителния бонус.
//След това въведете по брой присъствия за всеки студент.
//Изчислете бонус точките за всеки студент според формулата.
//Намерете студента с най-голям бонус и изведете този бонус, както и броя на неговите присъствия, закръглени нагоре до най-близкото цяло число.

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectors = int.Parse(Console.ReadLine());
            int bonos = int.Parse(Console.ReadLine());

            List<int> attendance = new List<int>();
            for (int i = 0; i < students; i++)
            {
                attendance.Add(int.Parse(Console.ReadLine()));
            }

            double maxAttendance = 0;
            if (attendance.Count > 0)
            {
                maxAttendance = attendance.Max();
            }

            double maxBonus = 0;
            if(maxAttendance != 0)
            {
                maxBonus = (maxAttendance / lectors) * (5 + bonos);
            }
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
