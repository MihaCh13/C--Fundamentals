using System;
using System.Collections.Generic;
using System.Linq;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputArrays = Console.ReadLine().Split("|").ToList();
            List<int> resultArray = new List<int>();

            for (int i = inputArrays.Count - 1; i >= 0; i--)
            {
                List<int> currentArray = inputArrays[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                     .Select(int.Parse)
                                                     .ToList();

                resultArray.AddRange(currentArray);
            }

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
