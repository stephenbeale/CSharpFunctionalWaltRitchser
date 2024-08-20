using CSharpFunctionalWaltRitchser;

class Program
{
    static void Main(string[] args)
    {
        Timer t = new Timer(TimerCallback, null, 0, 100);
        Console.ReadLine();
    }

    private static void TimerCallback(Object o) 
    {
        var examples = new Examples();
        Console.Clear();

        //Makes this function impure since time is always different
        Console.WriteLine(DateTime.Now);
        var result =
            examples.GetCurrentTimeRoundedUpToCustomMinuteInterval(4);
        Console.WriteLine(result);
    }
}