using CSharpFunctionalWaltRitchser;

using System.Collections.Immutable;

class Program
{
    static void Main(string[] args)
    {

        var examples = new Examples();
        ImmutableList<int> myImmutableList = ImmutableList.Create(1, 2, 3);
        //This is makes no changes to list
        var result = examples.AddNumbersToList(myImmutableList);
        Console.WriteLine($"Result of first add numbers: {result.Count()}");

        //This is also fine as it creates a new list on the fly
        var myNewImmutableList = examples.AddNumbersToList(myImmutableList);
        Console.WriteLine($"Result of second add numbers: {myNewImmutableList.Count()}");  
    }
}