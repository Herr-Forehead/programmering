//Console.WriteLine("Hej Nti");
//Console.WriteLine("Hej Te21B");

string name;
string food;
string fSport;
string iSport;

Console.WriteLine("Vad heter du?");
name = Console.ReadLine();

Console.WriteLine("Vad för mat ogillar du?");
food = Console.ReadLine();

Console.WriteLine("Vad är din favorit sport?");
fSport = Console.ReadLine();

Console.WriteLine("vilken sport gillar du inte?");
iSport = Console.ReadLine();

Console.WriteLine($"Hej {name}! du har precis vunnit en biljett det bästa hotellet någonsin, där {food} serveras varje dag, {fSport} är olagligt och {iSport} är obligatoriskt. Ses snart~! (ps. Du kan också kolla på Morbius varje dag)");

Console.WriteLine("bye")

Console.ReadLine();