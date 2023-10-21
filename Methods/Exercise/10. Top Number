using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TopNum();
        }

        static void TopNum()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopNumber(int number)
        {
            int sumOfDigits = 0;
            bool hasOddDigit = false;

            while (number > 0)
            {
                int digit = number % 10;
                sumOfDigits += digit;

                if (digit % 2 != 0)
                {
                    hasOddDigit = true;
                }

                number /= 10;
            }

            return sumOfDigits % 8 == 0 && hasOddDigit;
        }
    }
}
