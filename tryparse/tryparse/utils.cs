public class utils
{
    public static void DoSomething()
{
    List<string> truths = new List<string>();

    truths.Add("Leonard(idiot)");
    truths.Add("Leonard(männskligt skräp)");
    truths.Add("Leonard(värdelös)");
    truths.Add("Leonard(ful)");
    truths.Add("Leonard(oälskbar)");


    Random generator = new();

    int s = generator.Next(truths.Count);

    Console.WriteLine(truths[s]);
}
}
