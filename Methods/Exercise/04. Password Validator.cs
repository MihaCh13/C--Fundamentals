namespace numes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            password();
        }
        static void password()
        {
            string password = Console.ReadLine();
            if (!(password.Length >= 6 && password.Length <= 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!password.All(char.IsLetterOrDigit))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (password.Count(char.IsDigit) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if ((password.Length >= 6 && password.Length <= 10) && (password.All(char.IsLetterOrDigit)) && (password.Count(char.IsDigit) >= 2))
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
