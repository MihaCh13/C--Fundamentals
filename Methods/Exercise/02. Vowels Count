namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            glasni();
        }
        static void glasni ()
        {
            string letter = Console.ReadLine();
            char[] word = letter.ToCharArray();
            int lenght = letter.Length;
            int count = 0;
            for (int i = 0; i< lenght; i++)
            {
                char currentChar = char.ToLower(word[i]);
                if (currentChar == 'a' || currentChar == 'o' || currentChar == 'i' || currentChar == 'u' || currentChar == 'y' || currentChar == 'e')
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
