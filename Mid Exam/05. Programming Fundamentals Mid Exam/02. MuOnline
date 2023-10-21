//Начална здраве: 100 и начални биткойни: 0.
//Всеки стая в подземието съдържа команда и число, разделени със интервал.
//Ако командата е "potion", излекувайте се с числото в стаята, но не повече от началното здраве (100).
//Ако командата е "chest", намерете няколко биткойни, указани в стаята.
//В противен случай, срещате чудовище и атаката му намалява вашето здраве.
//Ако не сте умряли (здраве <= 0), сте убили чудовището и отпечатайте подходящото съобщение.
//Ако сте умрели, отпечатайте съобщението за смърт и най-добрата стая, до която сте стигнали.
//Ако сте преминали през всички стаи, отпечатайте съобщение за успех и текущите биткойни и здраве.

List<string> rooms = Console.ReadLine().Split('|').ToList();
int health = 100;
int bitcoin = 0;
int roomCount = rooms.Count;
int counter = 0;

for (int i = 0; i < roomCount; i++)
{
    string[] typeRoom = rooms[i].Split(' ');
    string command = typeRoom[0];

    if (command == "potion")
    {
        int hp = int.Parse(typeRoom[1]);
        health += hp;

        if (health > 100)
        {
            hp = hp - (health - 100);
            health = 100;
        }

        Console.WriteLine($"You healed for {hp} hp.");
        Console.WriteLine($"Current health: {health} hp.");
    }
    else if (command == "chest")
    {
        int foundBitcoins = int.Parse(typeRoom[1]);
        bitcoin += foundBitcoins;
        Console.WriteLine($"You found {foundBitcoins} bitcoins.");
    }
    else
    {
        string monster = typeRoom[0];
        int attack = int.Parse(typeRoom[1]);
        health -= attack;

        if (health > 0)
        {
            Console.WriteLine($"You slayed {monster}.");
        }
        else
        {
            Console.WriteLine($"You died! Killed by {monster}.");
            Console.WriteLine($"Best room: {counter + 1}");
            break;
        }
    }

    counter++;
}

if (counter == roomCount)
{
    Console.WriteLine("You've made it!");
    Console.WriteLine($"Bitcoins: {bitcoin}");
    Console.WriteLine($"Health: {health}");
}
