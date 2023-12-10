using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string link = Console.ReadLine();
        while (true)
        {
            if (link.Contains("\\") == true)
            {
                int IndexToRemove = link.IndexOf("\\");
                link = link.Remove(0, IndexToRemove+1);
            }
            else { break; }
        }
        string[] name = link.Split(".").ToArray();
        Console.WriteLine($"File name: {name[0]}\nFile extension: {name[1]}");
    }
}
