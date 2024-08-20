using CSharpFunctionalWaltRitchser;

class Program
{
    static void Main(string[] args)
    {
        Timer t = new Timer(TimerCallback, null, 0, 100);
        Console.ReadLine();

        //Me playing with named arguments
        DateTime dt1 = new DateTime(month: 1, day: 7, year: 2027);
        DateTime dt2 = new DateTime(month: 11, day: 4, year: 2056);
        var dateTimeNow = DateTime.Compare(dt1, dt2);
    }

    private static void TimerCallback(Object o) 
    {
        var examples = new Examples();
        Console.Clear();

        //Makes this function impure since time is always different
        Console.WriteLine(DateTime.Now);
        var result =
            examples.GetCurrentTimeRoundedUpToCustomMinuteInterval(4, DateTime.Now);
        Console.WriteLine(result);
    }
}