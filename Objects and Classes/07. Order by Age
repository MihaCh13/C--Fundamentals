using System;
using System.Globalization;
using System.Linq;

public class IDinformation
{
    // В този клас можете да добавите свойства или други членове според вашите изисквания
    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<IDinformation> information = new List<IDinformation>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            // Разделяме входа на отделни стрингове, като използваме интервал като разделител
            string[] idInfo = input.Split(" ");
            string name = idInfo[0];
            string id = idInfo[1];
            int age = int.Parse(idInfo[2]);

            IDinformation idInformation = new IDinformation
            {
                Name = name,
                ID = id,
                Age = age
            };
            information.Add(idInformation);
        }
        information.Sort((x, y) => x.Age.CompareTo(y.Age));

        foreach (var idInfo in information)
        {
            Console.WriteLine($"{idInfo.Name} with ID: {idInfo.ID} is {idInfo.Age} years old.");
        }

    }
}
