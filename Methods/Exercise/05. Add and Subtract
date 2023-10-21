using System;

namespace numes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Извикай ThirthDigit три пъти, за да вземеш три цели числа
            int one = ThirthDigit();
            int two = ThirthDigit();
            int tree = ThirthDigit();

            // Извикай FirstTwoDigits с въведените числа
            FirstTwoDigits(one, two, tree);
        }

        // Метод за въвеждане на цяло число от потребителя
        static int ThirthDigit()
        {
            return int.Parse(Console.ReadLine());
        }

        // Метод за изчисление на сумата на първите две цифри и изваждане на третата цифра
        static void FirstTwoDigits(int one, int two, int tree)
        {
            int sum = one + two;
            int result = sum - tree;

            // Изведи резултата
            Console.WriteLine(result);
        }
    }
}
