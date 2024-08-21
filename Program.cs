using CSharpFunctionalWaltRitchser;

using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        var examples = new Examples();
        examples.DoWork();
        var myDay = examples.GetDayAsNumber("My Day");
        Console.WriteLine($"{myDay} as number is: {myDay.ToString()}");
        myDay = examples.GetDayAsNumber("No");
        Console.WriteLine($"{myDay} as number is: {myDay.ToString()}");
        myDay = examples.GetDayAsNumber("Monday");
        Console.WriteLine($"{myDay} as number is: {myDay.ToString()}");

    }
}