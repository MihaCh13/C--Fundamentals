using System;

class Program
{
    static void Main(string[] args)
    {
        string words = Console.ReadLine();
        char[] characters = string.Join("", words).ToCharArray();
        int len = characters.Length;
        int letterNum = 0;
        char letter = ' ';
        List<char> list = new List<char>();

        for (int i = 0; i < len; i++)
        {
            letterNum = characters[i] + 3;
            letter = (char)letterNum;
            list.Add(letter);
        }
        Console.WriteLine(list.ToArray());
    }
}
