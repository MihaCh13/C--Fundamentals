using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var company = new Dictionary<string, List<string>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            string[] personID = input.Split(" -> ").ToArray();
            string name = personID[0];
            string id = personID[1];

            if (!company.ContainsKey(name))
            {
                company[name] = new List<string>();
            }

            if (!company[name].Contains(id))
            {
                company[name].Add(id);
            }
        }

        foreach (KeyValuePair<string, List<string>> kvp in company)
        {
            string companyName = kvp.Key;
            List<string> employeeIds = kvp.Value;

            Console.WriteLine(companyName);
            foreach (string id in employeeIds)
            {
                Console.WriteLine($"-- {id}");
            }
        }
    }
}
