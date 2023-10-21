using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int sum = 0;
        int str = int.Parse(input);

        for (int i = 0; i < input.Length; i++)
        {
            int digit = int.Parse(input[i].ToString());
            int n = 1;
            for (int j = 1; j <= digit; j++)
            {
                n *= j;
            }
            sum += n;
        }

        if (sum == str)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
