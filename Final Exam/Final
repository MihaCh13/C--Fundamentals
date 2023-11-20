using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string commands = Console.ReadLine();

            while (commands!="Done")
            {
                string [] commandargs = commands.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
                string commtype = commandargs[0];
                if (commtype == "TakeOdd")
                {
                    char[] Oddchars = password.Where((symbol, index) => index % 2 != 0).ToArray();
                    password = string.Join("", Oddchars);
                    Console.WriteLine(password);
                }
                else if (commtype == "Cut")
                {
                    password = password.Remove(int.Parse(commandargs[1]), int.Parse(commandargs[2]));
                    Console.WriteLine(password);

                }
                else if (commtype == "Substitute")
                {
                    string substring = commandargs[1];
                    string substitute = commandargs[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
