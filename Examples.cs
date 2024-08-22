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
        public void DoWorkWithPipeline()
        {
            int value = 5;
            
            int resultA = value.ToFourthPower().MakeNegative();
            int resultB = value.ToFourthPower().MakeNegative().AddTo(10);
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
