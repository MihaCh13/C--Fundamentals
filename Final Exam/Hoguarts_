using System;

namespace _001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Abracadabra")
            {
                string[] commArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (commArr[0] == "Abjuration")
                {


                    encryptedMessage = encryptedMessage.ToUpper().ToString();
                    Console.WriteLine(encryptedMessage);

                }
                else if (commArr[0] == "Necromancy")
                {
                    encryptedMessage = encryptedMessage.ToLower().ToString();
                    Console.WriteLine(encryptedMessage);
                }
                else if (commArr[0] == "Illusion")
                {
                    int index = int.Parse(commArr[1]);
                    string letter = commArr[2];
                    if (index >= 0 && index < encryptedMessage.Length)
                    {
                        encryptedMessage = encryptedMessage.Remove(index,1);
                        encryptedMessage = encryptedMessage.Insert(index, letter);
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }

                }
                else if (commArr[0] == "Divination")
                {
                    string firstSub = commArr[1];
                    string secondSub = commArr[2];
                    if (encryptedMessage.Contains(firstSub))
                    {
                        encryptedMessage = encryptedMessage.Replace(firstSub, secondSub);
                        Console.WriteLine(encryptedMessage);
                    }
                    

                }
                else if (commArr[0] == "Alteration")
                {
                    string firstSub = commArr[1];
                    if (encryptedMessage.Contains(firstSub))
                    {
                        encryptedMessage = encryptedMessage.Remove(encryptedMessage.IndexOf(firstSub), firstSub.Length);

                        Console.WriteLine(encryptedMessage);

                    }
                    else
                    {
                        Console.WriteLine("The spell did not work!");
                    }


                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }

            }

        }
    }
}
