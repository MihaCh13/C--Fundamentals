using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrays = int.Parse(Console.ReadLine());
            string [] nums = new string[arrays];
            string[] humti = new string[arrays];
            int count = 0;
            for (int i = 0; i < arrays; i++)
            {
                string[] array = Console.ReadLine().Split(' ');
                count++;
                if (count % 2 == 0)
                {
                    nums[i] = array[1];
                    humti[i] = array[0];
                }
                else
                {
                    nums[i] = array[0];
                    humti[i] = array[1];
                }
            }
            Console.Write("");
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("");
            foreach(var num in humti)
            {
                Console.Write(num + " ");
            }
        }
    }
}
