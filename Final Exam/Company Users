using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> companyEmployee = new Dictionary<string, HashSet<string>>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] inputArray = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = inputArray[0].Trim();
                string employeeId = inputArray[1].Trim();
                if (!companyEmployee.ContainsKey(companyName))
                {
                    companyEmployee.Add(companyName, new HashSet<string>() { employeeId});
                }
                else
                {
                    companyEmployee[companyName].Add(employeeId);
                }
                input = Console.ReadLine();
            }
            foreach (var company in companyEmployee)
            {
                Console.WriteLine($"{company.Key}");
                
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }




        }
    }
}
