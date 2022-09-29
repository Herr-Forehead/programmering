
// Console.WriteLine("Hej");
// string name = Console.ReadLine();
// Console.WriteLine(name);

// Console.WriteLine("FÖRE");
// DescribeRoom();
// Console.WriteLine("EFTER");

string a = AskYesNo("R u Williom(stooped)");
if (a == "n")
{
    string b = AskYesNo("R u Leonard(still stooped)");
    if (b == "y")
    {
        Console.WriteLine("waaw");
    }
}


Console.ReadLine();

static string AskYesNo(string question)
{
    Console.WriteLine(question);
    Console.WriteLine("[y/n]");
    string answer = Console.ReadLine();

    return answer;
}





static void DescribeRoom()
{
    Console.WriteLine("I am verii stupid");

    DescribeRoom();
}



