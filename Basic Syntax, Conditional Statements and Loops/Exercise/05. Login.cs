using System;
  
class Program
{
    static void Main(string[] args)
    { 
        string username = Console.ReadLine();
        string reversedUsername = ReverseString(username);
        int attempts = 0;

        while (true)
        {
            string inputPassword = Console.ReadLine();
            attempts++;

            if (inputPassword == reversedUsername)
            {
                Console.WriteLine($"User {username} logged in.");
                break;
            }
            else if (attempts == 4)
            {
                Console.WriteLine($"User {username} blocked!");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
