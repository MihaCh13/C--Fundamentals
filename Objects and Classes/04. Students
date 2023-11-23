using System;
using System.Collections.Generic;

public class Students
{
    public List<string> fName = new List<string>();
    public List<string> lName = new List<string>();
    public List<double> grade = new List<double>();

    public void AddStudent(string firstName, string lastName, double studentGrade)
    {
        fName.Add(firstName);
        lName.Add(lastName);
        grade.Add(studentGrade);
    }
}

public class Solutions
{
    private Students students;

    public Solutions(Students students)
    {
        this.students = students;
    }

    public void PrintSortedGrades()
    {
        List<double> sortedGrades = new List<double>(students.grade);
        sortedGrades.Sort((a, b) => b.CompareTo(a));
        int length = sortedGrades.Count;
        List<int> index = new List<int>();

        for (int i = 0; i < length; i++)
        {
            double searchValue = sortedGrades[i];

            // Търсене на индекса на стойността в листа
            int indexs = students.grade.IndexOf(searchValue);
            index.Add(indexs);
        }

        for (int i = 0; i < length; i++)
        {
            int gradeIndex = index[i];
            Console.WriteLine($"{students.fName[gradeIndex]} {students.lName[gradeIndex]}: {sortedGrades[i]:f2}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Students students = new Students();

        int numStudents = int.Parse(Console.ReadLine());

        for (int i = 0; i < numStudents; i++)
        {
            List<string> studentData = Console.ReadLine().Split(" ").ToList();
            string firstName = studentData[0];
            string lastName = studentData[1];
            double studentGrade = double.Parse(studentData[2]);

            students.AddStudent(firstName, lastName, studentGrade);
        }

        Solutions solutions = new Solutions(students);
        solutions.PrintSortedGrades();
    }
}
