using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Attack
    {
        public Attack(string planetName, long population, string attackType, long soldiersCount)
        {
            PlanetName = planetName;
            Population = population;
            AttackType = attackType;
            SoldiersCount = soldiersCount;
        }

        public string PlanetName { get; set; }
        public long Population { get; set; }
        public string AttackType { get; set; }
        public long SoldiersCount { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int messages = int.Parse(Console.ReadLine());
            List<Attack> attackList = new List<Attack>();
            for (int i = 0; i < messages; i++)
            {
                string input = Console.ReadLine();
                int key = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    bool isStar = "starSTAR".Contains(input[j]);
                    if (isStar)
                    {
                        key++;
                    }
                }

                StringBuilder messageBuilder = new StringBuilder();
                for (int j = 0; j < input.Length; j++)
                {
                    char currentChar = input[j];
                    char encryptedChar = (char)(currentChar - key);
                    messageBuilder.Append(encryptedChar);
                }
                string message = messageBuilder.ToString();
                string pattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*\:(?<population>\d+)[^\@\-\!\:\>]*\!(?<type>A|D)\![^\@\-\!\:\>]*\-\>[^\@\-\!\:\>]*?(?<soldiers>\d+)[^\@\-\!\:\>]*";

                foreach (Match item in Regex.Matches(message, pattern))
                {
                    string planet = item.Groups["planet"].Value;
                    long population = long.Parse(item.Groups["population"].Value);
                    string attackType = item.Groups["type"].Value.ToUpper();
                    long soldierCount = long.Parse(item.Groups["soldiers"].Value);
                    Attack attack = new Attack(planet, population, attackType, soldierCount);
                    attackList.Add(attack);
                }

            }
            List<Attack> attackedPlanets = attackList.OrderBy(p => p.PlanetName).Where(x => x.AttackType == "A").ToList();
            int attackedPlanetsCount = attackedPlanets.Where(x => x.AttackType == "A").Count();
            Console.WriteLine($"Attacked planets: {attackedPlanetsCount}");
            foreach (Attack planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet.PlanetName}");
            }

            List<Attack> destroyedPlanets = attackList.OrderBy(p => p.PlanetName).Where(x => x.AttackType == "D").ToList();
            int destroyedPlanetsCount = destroyedPlanets.Where(x => x.AttackType == "D").Count();

            Console.WriteLine($"Destroyed planets: {destroyedPlanetsCount}");
            foreach (Attack planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet.PlanetName}");
            }
        }
    }
}
