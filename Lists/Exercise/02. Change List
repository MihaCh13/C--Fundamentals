using System;
using System.Collections.Generic;
using System.Linq;
namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                if (command.Count > 1)
                {
                    if (command[0] == "Delete")
                    {
                        int newNum = int.Parse(command[1]);
                        integers.RemoveAll(x => x == newNum);
                    }
                    else if (command[0] == "Insert")
                    {
                        int newNums = int.Parse(command[1]);
                        int position = int.Parse(command[2]);
                        integers.Insert(position, newNums);
                    }
                }
                else { break; }
            }
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
