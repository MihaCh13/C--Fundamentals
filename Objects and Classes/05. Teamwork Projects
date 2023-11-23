using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            Dictionary<string, string> teams = new Dictionary<string, string>();
            Dictionary<string, List<string>> members = new Dictionary<string, List<string>>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] input = Console.ReadLine().Split("-");

                string user = input[0];
                string team = input[1];

                if (teams.ContainsKey(team))
                {
                    Console.WriteLine($"Team {team} was already created!");
                    continue;
                }

                if (teams.ContainsValue(user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }

                teams.Add(team, user);
                members.Add(team, new List<string>());

                Console.WriteLine($"Team {team} has been created by {user}!");
            }

            string assignment = Console.ReadLine();

            while (assignment != "end of assignment")
            {
                string[] input = assignment.Split("->");

                string user = input[0];
                string team = input[1];

                if (!teams.ContainsKey(team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    assignment = Console.ReadLine();
                    continue;
                }

                if (members.Values.Any(m => m.Contains(user)) || teams.ContainsValue(user))
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                    assignment = Console.ReadLine();
                    continue;
                }

                members[team].Add(user);

                assignment = Console.ReadLine();
            }

            foreach (var team in members
                .Where(t => t.Value.Count > 0)
                .OrderByDescending(t => t.Value.Count)
                .ThenBy(t => t.Key))
            {
                Console.WriteLine(team.Key);
                Console.WriteLine($"- {teams[team.Key]}");

                foreach (var member in team.Value.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in members
                .Where(t => t.Value.Count == 0)
                .OrderBy(t => t.Key))
            {
                Console.WriteLine(team.Key);
            }
        }
    }
}
