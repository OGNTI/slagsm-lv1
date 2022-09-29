int playerHp;
int botHp;
int playerDmg = 10;
int botDmg = 12;
int dmg;
int botNum;
int round;
int streak = 0;
string name;
string bot = "pebble";
string botW = "pebble";
string playerW = "pebble";
string answer1;
string answer2 = "pebble";
bool weapon = false;
bool program = true;
Random generator = new Random();

Console.WriteLine("You, Fighter. What is your name?");
name = Console.ReadLine();

while(program == true)
{
    fight();
}

void fight()
{
    playerHp = 100;
    botHp = 100;
    round = 1;

    botNum = generator.Next(1, 16);
    if (botNum == 1)
    {
        bot = "John";
        botW = "an energy sword";
        botDmg = 14;
    }
    else if (botNum == 2)
    {
        bot = "Steve";
        botW = "a diamond sword";
        botDmg = 7;
    }
    else if (botNum == 3)
    {
        bot = "Charles";
        botW = "an axe";
        botDmg = 11;
    }
    else if (botNum == 4)
    {
        bot = "Maximus";
        botW = "a short sword";
        botDmg = 10;
    }
    else if (botNum == 5)
    {
        bot = "Kassandra";
        botW = "a staff";
        botDmg = 10;
    }
    else if (botNum == 6)
    {
        bot = "Karen";
        botW = "a frying Pan";
        botDmg = 8;
    }
    else if (botNum == 7)
    {
        bot = "Gordon";
        botW = "a crowbar";
        botDmg = 9;
    }
    else if (botNum == 8)
    {
        bot = "Bobby";
        botW = "a chainsaw";
        botDmg = 15;
    }
    else if (botNum == 9)
    {
        bot = "God";
        botW = "smite";
        botDmg = 20;
    }
    else if (botNum == 10)
    {
        bot = "Jeremy";
        botW = "a golf club";
        botDmg = 7;
    }
    else if (botNum == 11)
    {
        bot = "Talion";
        botW = "a sword";
        botDmg = 13;
    }
    else if (botNum == 12)
    {
        bot = "Ezio";
        botW = "a hidden blade";
        botDmg = 12;
    }
    else if (botNum == 13)
    {
        bot = "Max";
        botW = "fists";
        botDmg = 10;
    }
    else if (botNum == 14)
    {
        bot = "Nora";
        botW = "a litteral gun";
        botDmg = 17;
    }
    else if (botNum == 15)
    {
        bot = "Slayer";
        botW = "BFG 9000";
        botDmg = 22;
    }

    Console.Clear();
    if (bot == "God")
    {
        Console.WriteLine($"In this next fight, we will see {name} against fucking God himself.");
    }
    else
    {
        Console.WriteLine($"In this next fight, we will see {name} against {bot}.");
    }

    while (weapon == false)
    {
        Console.WriteLine("Fighters, choose your weapons.");
        Console.WriteLine("You are presented with Azkâr, a dagger, the Master Sword, a hammer, a ring, The Godkiller, \na curved blade, the Noisy Cricket and a broken wand.");
        Console.WriteLine("What do you choose?");
        answer1 = Console.ReadLine();
        answer2 = answer1.ToLower();

        if (answer2 == "azkar" || answer2 == "bow")
        {
            playerDmg = 11;
            answer2 = "Azkâr";
            playerW = "bow";
            break;
        }
        else if (answer2 == "dagger")
        {
            playerDmg = 10;
            answer2 = "Sting";
            playerW = "dagger";
            break;
        }
        else if (answer2 == "sword" || answer2 == "master sword" || answer2 == "the master sword" || answer2 == "master")
        {
            playerDmg = 14;
            answer2 = "the Master Sword";
            playerW = "sword";
            break;
        }
        else if (answer2 == "hammer")
        {
            playerDmg = 15;
            answer2 = "Mjolnir";
            playerW = "hammer";
            break;
        }
        else if (answer2 == "ring")
        {
            playerDmg = 18;
            answer2 = "The One Ring";
            playerW = "ring";
            break;
        }
        else if (answer2 == "godkiller" || answer2 == "the godkiller" || answer2 == "god" || answer2 == "killer")
        {
            playerDmg = 8;
            answer2 = "The Godkiller";
            playerW = "godkiller";
            break;
        }
        else if (answer2 == "curved blade" || answer2 == "blade" || answer2 == "curved")
        {
            playerDmg = 13;
            answer2 = "bat'leth";
            playerW = "blade";
            break;
        }
        else if (answer2 == "noisy cricket" || answer2 == "the noisy cricket" || answer2 == "cricket" || answer2 == "noisy")
        {
            playerDmg = 16;
            answer2 = "the Noisy Cricket";
            playerW = "blaster";
            break;
        }
        else if (answer2 == "wand" || answer2 == "broken wand" || answer2 == "broken")
        {
            playerDmg = 20;
            answer2 = "a wand";
            playerW = "wand";
            break;
        }
    }

    if (bot == "God")
    {
        Console.WriteLine($"{name} chose {answer2} and God will use smite.");
    }
    else
    {
        Console.WriteLine($"{name} chose {answer2} and {bot} chose {botW}.");
    }

    while (answer2 != "yes")
    {
        Console.WriteLine("Fighters, are you ready?");
        answer1 = Console.ReadLine();
        answer2 = answer1.ToLower();
    }

    Console.Clear();
    Console.WriteLine("Match Start");
    Console.WriteLine($"{name} {playerHp}/100");
    Console.WriteLine($"{bot} {botHp}/100");
    Console.WriteLine("You start, press enter to attack.");
    Console.ReadLine();

    while (playerHp > 0 && botHp > 0)
    {
        if (playerW == "wand")
        {
            dmg = generator.Next(-8, playerDmg);
        }
        else
        {
            dmg = generator.Next(playerDmg / 2, playerDmg);
        }

        if (playerW == "ring" && round == 4)
        {
            playerHp -= 50;
        }
        else
        {
            botHp -= dmg;
            if (botHp < 0)
            {
                botHp = 0;
            }
        }

        Console.Clear();
        Console.WriteLine($"Round {round}");
        Console.WriteLine($"{name} {playerHp}/100");
        Console.WriteLine($"{bot} {botHp}/100");
        if (dmg > playerDmg - playerDmg / 4)
        {
            Console.WriteLine($"You hit {bot} with a crit dealing {dmg} damage. Press enter to continue.");
        }
        else if (playerW == "wand" && dmg < 0)
        {
            Console.WriteLine($"You accidentally cast a healing spell on {bot} which healed him for {-dmg}. Press enter to continue.");
        }
        else if (playerW == "wand" && dmg == 0)
        {
            Console.WriteLine($"You tried to use a fireball spell on {bot} but failed and did no damage. Press enter to continue.");
        }
        else if (playerW == "ring" && round == 4)
        {
            Console.WriteLine("The power of the one ring is too much for you.");
            if (playerHp < 1)
            {
                Console.WriteLine("You are corrupted by the ring and mortally hurt yourself, your soul now belongs to Sauron. \nPress enter to continue.");
                break;
            }
            else
            {
                Console.WriteLine("You are corrupted by the ring and hurt yourself dealing 50 damage. Press enter to continue.");
            }
        }
        else if (playerW == "godkiller" && round == 10)
        {
            Console.WriteLine($"You hit {bot} for {dmg} but the Godkiller broke. Press enter to continue.");
            playerDmg = playerDmg/3 + 1;
        }
        else
        {
            Console.WriteLine($"You hit {bot} for {dmg} damage. Press enter to continue.");
        }
        Console.ReadLine();
        if (botHp < 1)
        {
            break;
        }
        dmg = generator.Next(botDmg / 2, botDmg);
        playerHp -= dmg;
        if (playerHp < 0)
            {
                playerHp = 0;
            }
        Console.Clear();
        Console.WriteLine($"Round {round}");
        Console.WriteLine($"{name} {playerHp}/100");
        Console.WriteLine($"{bot} {botHp}/100");
        if (dmg > botDmg - botDmg / 4)
        {
            Console.WriteLine($"{bot} hit you with a crit dealing {dmg} damage. Press enter to continue.");
        }
        else
        {
            Console.WriteLine($"{bot} hit you for {dmg} damage. Press enter to continue.");
        }
        round++;
        Console.ReadLine();
        if (playerHp < 1)
        {
            break;
        }
    }

    if (botHp < 1)
    {
        if (playerHp < 8)
        {
            Console.WriteLine($"Congratualtions, {name} barely won the fight against {bot}.");
        }
        else
        {
            Console.WriteLine($"Congratualtions, {name} won the fight against {bot}.");
        }
        streak++;
        Console.WriteLine($"Current winstreak: {streak}.");
        answer2 = "pebble";
        while (answer2 != "yes")
        {
            if (answer2 == "yes" || answer2 == "no") 
            {
                break;
            }
            Console.WriteLine("Do you want to fight again?");
            answer1 = Console.ReadLine();
            answer2 = answer1.ToLower();
        }
        if (answer2 != "yes")
        {
            program = false;
        }
    }
    else if (playerHp < 1)
    {
        if (playerW == "bow" && bot == "Talion")
        {
            Console.WriteLine($"Talion won the fight against {name} and reclaimed Azkâr.");
        }
        else if (botHp < 8)
        {
            Console.WriteLine($"{bot} barely won the fight against {name}.");
        }
        else
        {
            Console.WriteLine($"{bot} won the fight against {name}.");
        }
        if (streak > 0)
        {
            Console.WriteLine("Your winstreak has been broken.");
            streak = 0;
        }

        answer2 = "pebble";
        while (answer2 != "yes")
        {
            if (answer2 == "yes" || answer2 == "no") 
            {
                break;
            }
            Console.WriteLine("Do you want to fight again?");
            answer1 = Console.ReadLine();
            answer2 = answer1.ToLower();
        }
        if (answer2 != "yes")
        {
            program = false;
        }
    }
}