using System;

namespace numes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMiddleCharacter();
        }

        static void PrintMiddleCharacter()
        {
            string text = Console.ReadLine();
            int len = text.Length;
            char[] str = text.ToCharArray();

            if (len % 2 == 0)
            {
                int middle1 = len / 2 - 1;  // Adjusted for 0-based indexing
                int middle2 = len / 2;
                Console.WriteLine($"{str[middle1]}{str[middle2]}");
            }
            else
            {
                int middle = len / 2;
                Console.WriteLine(str[middle]);
            }
        }
    }
}
