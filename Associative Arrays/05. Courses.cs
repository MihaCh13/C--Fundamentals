using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var courses = new Dictionary<string, List<string>>();
        
        while (true)
        {
            List<string> names = Console.ReadLine().Split(" : ").ToList();
            string courseName = names[0];

            if (courseName == "end")
            {
                break;
            }

            string studentsName = names[1];

            if (!courses.ContainsKey(courseName))
            {
                courses[courseName] = new List<string>();
                courses[courseName].Add(studentsName);
            }
            else
            {
                courses[courseName].Add(studentsName);
            } 
        }
        foreach (KeyValuePair< string, List<string>> kvp in courses)
        {
            int count = kvp.Value.Count;
            Console.WriteLine($"{kvp.Key}: {count}");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"-- {kvp.Value[i]}");
            }
        }
    }
}



