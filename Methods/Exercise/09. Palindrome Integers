using System;

class Program
{
    static void Main()
    {
        PalindromeCheck();
    }

    static void PalindromeCheck()
    {
        string num = Console.ReadLine();

        while (num != "END")
        {
            int len = num.Length;
            char[] str = num.ToCharArray();
            bool isPalindrome = true;

            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine(isPalindrome ? "true" : "false");

            num = Console.ReadLine(); // Read the next input
        }
    }
}
