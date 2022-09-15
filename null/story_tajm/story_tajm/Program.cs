
string restart = "yes";

while (restart == "yes")
{

    Console.WriteLine("You wake up at the crossroads in a forest, and when you look behind you the path is cut off by a huge ravine. When you look towards the left you see a path riddled with marks from multiple wheels and hooves. When you look to the right you see a path leading to a far away glade with smoke rising in the distance. What do you do?");
    string choiceBeginning = Console.ReadLine();
    if (choiceBeginning == "left")
    {
        Console.WriteLine("You walk along the tracks and arrive at an abandoned campsite. Although the campsite seems to have been left in quite a hurry, around the abandoned campsite remain parts of the caravans cargo. From the campsite does the path continue, allowing you to either inspect the abandoned campsite or continue down the path...");
        string choiceCampsite = Console.ReadLine();
        if (choiceCampsite == "inspect")
        {
            Console.WriteLine("You decide to inspect the campsite and find that a couple of the left crates hold different kinds of jewelry. One even holds an beautiful looking dagger. Do you take it?");
            string choiceInspect = Console.ReadLine();
            if (choiceInspect == "yes")
            {
                Console.WriteLine("you take the dagger. Do you want to inspecting the campsite or do you continue walking down the path(y/n)");
                string choiceDagger = "yes";
                while (choiceDagger == "yes" || choiceDagger == "y")
                {
                    Console.WriteLine("with a dagger in hand you continue down the path.");
                }

            }
            else 
            {
                Console.WriteLine("You do not take the dagger.");
            }
        }
        else if (choiceCampsite == "cum")
        {
            Console.WriteLine("The cum monster killed you!");
            Console.WriteLine("want to try again?");
            if (restart == "yes")
            {
                restart = Console.ReadLine();
            }
            else if (restart == "cum")
            {
                Console.WriteLine("*insert graphic description of cum monster killing you*");
            }
            else
            {
                restart = Console.ReadLine();
            }
        }
        else if (choiceCampsite == "continue")
        {
            Console.WriteLine("You continue down the path ");
        }
        else
        {
            Console.WriteLine("You didn't get lake but could look at the sword.");
        }
    }
    else if (choiceBeginning == "right")
    {
        Console.WriteLine("You walk along the path to the right, passing through the still glade eventually reaching a small run down house. You notice that the smoke you saw earlier was coming from the house's chimney, but when you get closer you see that no one is home. You could choose to enter or not. What do you do?");
        string choiceHouse = Console.ReadLine();
        if (choiceHouse == "enter")
        {
            Console.WriteLine("You open the door to the house and immedeately notices that there's a kettle with something brewing inside.");
        }
    }
    else if (choiceBeginning == "cum")
    {
        Console.WriteLine("You were killed by the cum monster.");
        Console.WriteLine("");
        Console.WriteLine("want to try again?");
        if (restart == "yes")
        {
            restart = Console.ReadLine();
        }
        else if (restart == "cum")
        {
            Console.WriteLine("*insert graphic description of cum monster killing you*");
        }
        else
        {
            restart = Console.ReadLine();
        }
    }
    else if (choiceBeginning == "nothing" || choiceBeginning == "wait")
    {
        Console.WriteLine("you decided to wait... ");
        Console.WriteLine("");
        Console.WriteLine("eventually you start hearing howling in the distance. Do you decide to wait or do you start running in any direction?");
        string choiceHowling = Console.ReadLine();
        if (choiceHowling == "run right" || choiceHowling == "right")
        {
            Console.WriteLine("You start to run towards the right, ");
        }
        else if(choiceHowling == "run left" || choiceHowling == "left")
        {
            Console.WriteLine("");
        }
    }
    else if (choiceBeginning == "jump")
    {
        Console.WriteLine("You decide to jump off the ravine and you die when you hit the ground.");
        Console.WriteLine("...");
        Console.WriteLine("what did you think was going to happen?");
        Console.WriteLine("");
        Console.WriteLine("wanna try again?");
        if (restart == "yes")
        {
            restart = Console.ReadLine();  
        }
        else
        {
           
        }
    }
    else
    {
        Console.WriteLine("waht?");
    }

    Console.WriteLine("You sure you want to restart?");
    restart = Console.ReadLine();
}

Console.ReadLine();