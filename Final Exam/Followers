using System;
using System.Collections.Generic;
using System.Linq;

namespace Followers
{
    class LikesComments
    {
        public string name;
        public int likes = 0;
        public int comments = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, LikesComments> users = new Dictionary<string, LikesComments>();


            string input = Console.ReadLine();
            while (input != "Log out")
            {
                string[] currCommand = input.Split(": ");
                if (currCommand[0] == "New follower")
                {
                    if (!users.ContainsKey(currCommand[1]))
                    {
                        LikesComments currUser = new LikesComments();
                        currUser.name = currCommand[1];
                        currUser.comments = 0;
                        currUser.likes = 0;
                        users.Add(currCommand[1], currUser);
                        //users.Add(currCommand[1], new LikesComments());
                        //users[currCommand[0]].comments = 0;
                        //users[currCommand[0]].likes = 0;

                    }
                }
                else if (currCommand[0] == "Like")
                {
                    if (!users.ContainsKey(currCommand[1]))
                    {
                        users.Add(currCommand[1], new LikesComments());
                        users[currCommand[1]].comments = 0;
                        users[currCommand[1]].likes += int.Parse(currCommand[2]);

                    }
                    else
                    {
                        users[currCommand[1]].likes += int.Parse(currCommand[2]);
                    }
                }
                else if (currCommand[0] == "Comment")
                {
                    if (!users.ContainsKey(currCommand[1]))
                    {
                        users.Add(currCommand[1], new LikesComments());
                        users[currCommand[1]].comments++;

                    }
                    else
                    {
                        users[currCommand[1]].comments++;
                    }
                }
                else if (currCommand[0] == "Blocked")
                {
                    if (!users.ContainsKey(currCommand[1]))
                    {
                        Console.WriteLine($"{currCommand[1]} doesn't exist.");
                    }
                    else
                    {
                        users.Remove(currCommand[1]);
                    }
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> newDict = new Dictionary<string, int>();

            foreach (var user in users)
            {
                int total = user.Value.comments + user.Value.likes;
                newDict.Add(user.Key, total);
            }

            newDict = newDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(pair => pair.Key,
                pair => pair.Value);
            Console.WriteLine($"{newDict.Count} followers");
            foreach (var VARIABLE in newDict)
            {
                Console.WriteLine($"{VARIABLE.Key}: {VARIABLE.Value}");
            }
        }
    }
}
