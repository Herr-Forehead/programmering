Random generator = new Random();
int hitRoll = generator.Next(101);
int dmg = generator.Next(51);
int crit = generator.Next(50,101);

int p1HP = 200;
int p2HP = 200;

while (p1HP > 0 && p2HP > 0)
{
    hitRoll = generator.Next(101);
    dmg = generator.Next(51);
    crit = generator.Next(50,101);
Console.WriteLine("BoringBasicHero attacks DaVillain");
    if (hitRoll > 99)
    {
        p2HP -= crit;
        Console.WriteLine($"BoringBasicHero lands a critical hit on DaVillain and deals {crit} damage");
        Console.WriteLine($"DaVillain now has {p2HP}HP left");
    }
    else if (hitRoll > 40)
    {
        p2HP -= dmg;
        Console.WriteLine($"BoringBasicHero slashes DaVillain with his BasicHeroSword'tm and deals {dmg} damage");
        Console.WriteLine($"DaVillain now has {p2HP}HP left");
    }
    else
    {
        Console.WriteLine("BoringBasicHero tries to attack DaVillain but DaVillain breakdance dodges the attack");
        Console.WriteLine($"In other words, the attack misses and DaVillain still has {p2HP}HP");
    }
    hitRoll = generator.Next(101);
    dmg = generator.Next(51);
    crit = generator.Next(50,101);
    Console.WriteLine("DaVillain proceeds to counter BoringBasicHero's attack with one of his own");
    if (hitRoll > 99)
    {
        p1HP -= crit;
        Console.WriteLine($"DaVillain starts breakdancing and implements a bunch of kicks and punches that all hit BoringBasicHero and deals {crit} damage");
        Console.WriteLine($"BoringBasicHero now has {p1HP}HP left");
    }
    else if (hitRoll > 40)
    {
        p1HP -= dmg;
        Console.WriteLine($"DaVillain does a basic breakdancing spin move and kicks BoringBasicHero in the face dealing {dmg} damage");
        Console.WriteLine($"BoringBasicHero now has {p1HP}HP left");
    }
    else
    {
        Console.WriteLine("DaVillain tries to breakdance attack BoringBasicHero but does one too many spins and tumbles");
        Console.WriteLine($"In other words, the attack misses and BoringBasicHero still has {p1HP}HP");
    }
    Console.WriteLine($"BoringBasicHero currently has {p1HP}HP left and DaVillain has {p2HP}HP left");
}

if (p1HP > 0 && p2HP < 0)
{
    Console.WriteLine("BoringBasicHero wins, somehow");
}
else if (p1HP < 0 && p2HP > 0)
{
    Console.WriteLine("DaVillain wins and breakdances on BoringBasicHero's corpse");
}
else if (p1HP == 0 || p1HP < 0  && p2HP == 0 || p2HP < 0)
{
    Console.WriteLine("No one wins");
}
else
{
    Console.WriteLine("how?");
}


Console.ReadLine();



// int x = 0;

// while (x < 800)
// {
//     Console.WriteLine(x);
//     Console.ReadLine();
//     x++;
// }


// Console.ReadLine();

// Random generator = new Random();

// int hitRoll = generator.Next(100);
// Console.WriteLine(hitRoll);

// if (hitRoll > 99)
// {
//     Console.WriteLine("CRIT!");
// }
// else if (hitRoll > 40)
// {
//     Console.WriteLine("HIT!");
// }
// else 
// {
//     Console.WriteLine("MISS!");
// }


// Console.ReadLine();
