using CSharpFunctionalWaltRitchser;

using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        var examples = new Examples();
        examples.UseEnumerablePipeline();
    }
}