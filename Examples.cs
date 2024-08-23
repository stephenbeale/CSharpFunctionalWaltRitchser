using NPOI.SS.Formula.Functions;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace CSharpFunctionalWaltRitchser
{
    public class Examples
    {
        public void DoWorkWithStandardLambda()
        {
            //Random Linq example from Perplexity, not the course. Code too hard for me to follow on course.
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            //Select 
            var squaredNumbers = numbers.Select(num => num * num);  // { 1, 4, 9, 16, 25 }
        }
    }

    public static class Extensions
    {
        public static int ToFourthPower(this int candidate)
        {
            return candidate * candidate * candidate * candidate;
        }

        public static int MakeNegative(this int candidate)
        {
            return candidate * -1;
        }

        public static int AddTo(this int candidate, int adder)
        {
            return candidate + adder;
        }
    }
}
