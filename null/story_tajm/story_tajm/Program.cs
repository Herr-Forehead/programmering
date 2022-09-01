
Console.WriteLine("You wake up in a verii scary forest and you see a lone path ahead, you can choose to walk it or not, what do?(yes/no)");
string choice1 = Console.ReadLine();
if(choice1 == "yes")
{
    Console.WriteLine("you walk further into the forest and find a lake in a sword, do you take it?(yes/no)");
    string choice2 = Console.ReadLine();
    if(choice2 == "yes")
    {
        Console.WriteLine("congrats you got a lake!");
    }
    else if(choice2 == "cum")
    {
        Console.WriteLine("The cum monster killed you!");
    }
    else
    {
        Console.WriteLine("You didn't get lake but could look at the sword.");
    }
}
else if(choice1 == "cum")
{
    Console.WriteLine("the cum monster killed you!");
}
else
{
    Console.WriteLine("you eventually fell asleep");
}

Console.ReadLine();