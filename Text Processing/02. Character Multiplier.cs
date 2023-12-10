using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        char[] word1 = words[0].Trim().ToCharArray();
        int lenWord1 = words[0].Length;
        char[] word2 = words[1].Trim().ToCharArray();
        int lenWord2 = words[1].Length;
        int sum = 0;
        int final = 0;
        int indexMultipy = 0;
        int restSum = 0;

        if (lenWord1 == lenWord2)
        {
            for (int i = 0; i < lenWord1; i++)
            {
                indexMultipy = (int)word1[i] * (int)word2[i];
                sum += indexMultipy;
                final = sum;
            }
        }
        else if (lenWord1 > lenWord2)
        {
            int difference = lenWord1 - lenWord2;
            for (int i = 0; i < lenWord2; i++)
            {
                indexMultipy = (int)word2[i] * (int)word1[i];
                sum += indexMultipy;
            }
            int firstIndex = lenWord1 - difference;
            string substring1 = new string(word1);
            string substring = substring1.Substring(firstIndex);
            for (int i = firstIndex; i < lenWord1; i++)
            {
                int index = (int)word1[i];
                restSum += index;
            }
            sum += restSum;
            final = sum;
        }
        else
        {
            int difference = lenWord2 - lenWord1;
            for (int i = 0; i < lenWord1; i++)
            {
                indexMultipy = (int)word2[i] * (int)word1[i];
                sum += indexMultipy;
            }
            int firstIndex = lenWord2 - difference;
            string substring1 = new string(word2);
            string substring = substring1.Substring(firstIndex);
            for (int i = firstIndex; i < lenWord2; i++)
            {
                int index = (int)word2[i];
                restSum += index;
            }
            final = sum + restSum;
        }
        Console.WriteLine(final);
    }
}
