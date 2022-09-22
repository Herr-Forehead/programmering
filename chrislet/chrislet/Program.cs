

int score = 0;
int right = 1;
Console.WriteLine("*Disclaimer Brain Damage*");
Console.WriteLine("");
string restart = "yes";
while (restart == "yes")
{
Console.WriteLine("what is your name?");
string name = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Are you reday to start the quiz?");
string start = Console.ReadLine();
if (start == "yes")
{
    Console.WriteLine("good");
    Console.WriteLine("");
    Console.WriteLine("Okay, question 1");
    Console.WriteLine("what color is the sky?");
    Console.WriteLine("a) blue, b) grass or c) space?");
    string Q1 = Console.ReadLine();
    if (Q1 == "a)" || Q1 == "a" || Q1 == "blue")
    {
        Console.WriteLine("wrong!");
    }
    else if (Q1 == "b)" || Q1 == "b" || Q1 == "grass")
    {
        Console.WriteLine("congrats, you got it right!*fanfare noises*");
        score += right;
    }
    else if (Q1 == "c)" || Q1 == "c" || Q1 == "space")
    {
        Console.WriteLine("Wrong!");
    }
    else
    {
        Console.WriteLine("waht?");
    }
    Console.WriteLine("");
    Console.WriteLine("time for question 2:");
    Console.WriteLine("What is William");
    Console.WriteLine("a)Smart, b) shark or c) cat");
    string Q2 = Console.ReadLine();
    if (Q2 == "a)" || Q2 == "a" || Q2 == "smart")
    {
        Console.WriteLine("Waaw, you guessed right!*fanfare noises*");
        score += right;
    }
    else if (Q2 == "b)" || Q2 == "b" || Q2 == "shark")
    {
        Console.WriteLine("You got it wrong, how crinch");
    }
    else if (Q2 == "c)" || Q2 == "c" || Q2 == "cat")
    {
        Console.WriteLine("You are crinch, because you got it wrong");
    }
    else 
    {
        Console.WriteLine("waht?");
    }
    Console.WriteLine("");
    Console.WriteLine("Now onto question 3");
    Console.WriteLine("How many dumb dumbs does Leonard do per day?");
    Console.WriteLine("a) all of them, b) 1 or c) 5");
    string Q3 = Console.ReadLine();
    if (Q3 == "a)" || Q3 == "a" || Q3 == "all of them")
    {
        Console.WriteLine("Huh, you actually got it right, congrats!*fanfare noises*");
        score += right;
    }
    else if (Q3 == "b)" || Q3 == "b" || Q3 == "1")
    {
        Console.WriteLine("Yinkies, you got it wrong");
    }
    else if (Q3 == "c)" || Q3 == "c" || Q3 == "5")
    {
        Console.WriteLine("too bad, you're an idiot who got it wrong");
    }
    else 
    {
        Console.WriteLine("waht?");
    }
    Console.WriteLine("");
    Console.WriteLine("So...");
    Console.WriteLine("...You've gotten this far without rage-quitting...");
    Console.WriteLine("...Impressive");
    Console.WriteLine("But brace yourself, for it's only going to get more difficult here on out");
    Console.WriteLine("question 4:");
    Console.WriteLine("What is Vidar(I hate him)");
    Console.WriteLine("a) horrible, b) okay or c) ugly");
    string Q4 = Console.ReadLine();
    if (Q4 == "a)" || Q4 == "a" || Q4 == "horrible")
    {
        Console.WriteLine("How crinch that you answered incorrectly");
        score -= right;
    }
    else if (Q4 == "b)" || Q4 == "b" || Q4 == "okay")
    {
        Console.WriteLine("You actually got that right, congrats!*fanfare noises*");
        score += right;
    }
    else if (Q4 == "c)" || Q4 == "c" || Q4 == "ugly")
    {
        Console.WriteLine("Ooh, close but not quite, how crinch");
        score -= right;
    }
    Console.WriteLine("");
    Console.WriteLine("Ok, Ok, now onto question 5:");
    Console.WriteLine("Have you ever had a dream that you, um, you had, your, you- you could, you'll do, you- you wants, you, you could do so, you- you'll do, you could- you, you want, you want them to do you so much you could do anything?");
    Console.WriteLine("a) yes, b) waht?, c) no");
    string Q5 = Console.ReadLine();
    if (Q5 == "a)" || Q5 == "a" || Q5 == "yes")
    {
        Console.WriteLine("Indeed*fanfare noises*");
        score += right;
    }
    else if (Q5 == "b)" || Q5 == "b" || Q5 == "waht")
    {
        Console.WriteLine("waht?*beep noise*");
        score -= right;
    }
    else if (Q5 == "c)" || Q5 == "c" || Q5 == "no")
    {
        Console.WriteLine("yeah, nah crinch");
        score -= right;
    }
    else 
    {
        Console.WriteLine("waht?");
    }
    Console.WriteLine("");
    Console.WriteLine("So you made it even this far...");
    Console.WriteLine("Now be prepared for the final and most difficult question, and be sure bot to ragequit");
    Console.WriteLine("Are five ants more than four elephants");
    Console.WriteLine("a) yes, b) no or c) which one does not fit in?");
    string Q6 = Console.ReadLine();
    if (Q6 == "a)" || Q6 == "a" || Q6 == "yes")
    {
        Console.WriteLine("I'm sorry but that's wrong");
        score -= right;
    }
    else if (Q6 == "b)" || Q6 == "b" || Q6 == "no")
    {
        Console.WriteLine("If you answered truthfully, then you didn't have a childhood but if yo're smart then congrats!*fanfare noises*");
        score += right;
    }
    else if (Q6 == "c)" || Q6 == "c" || Q6 == "which one does not fit in?")
    {
        Console.WriteLine("Sad that you got it wrong, crinch...");
        score -= right;
    }
    else
    {
        Console.WriteLine("waht?");
    }
}
else if (start == "no")
{
    Console.WriteLine("sad :(");
}
else 
{
    Console.WriteLine("waht?");
}

Console.WriteLine("");
if (score == -3)
{
    Console.WriteLine("Wow, you must be really bad");
}
else if (score == -2)
{
    Console.WriteLine("at least you got one right...");
}
else if (score == -1)
{
    Console.WriteLine("More right guesses than I thought you'd get");
}
else if (score == 0)
{
    Console.WriteLine("Good start, Bad ending");
}
else if(score == 1)
{
    Console.WriteLine("Finally figured it out didya?");
}
else if(score == 2)
{
    Console.WriteLine("Getting into the rhythm are ya");
}
else if(score == 3)
{
    Console.WriteLine("Bad start, Good end");
}
else if (score == 4)
{
    Console.WriteLine("how????");
}
else if (score == 5)
{
    Console.WriteLine("Is it possible to learn this powah?");
}
else if (score == 6)
{
    Console.WriteLine("That's not even possible, Cheater");
}
Console.WriteLine(score);
Console.WriteLine("do you want to restart?");
restart = Console.ReadLine();
}


Console.ReadLine();