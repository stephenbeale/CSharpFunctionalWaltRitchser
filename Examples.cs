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
    internal class Examples
    {
        public void SelectWithNoTransform()
        {
            //functional Map == LINQ Select
            //transform each item in the list

            var numbers = Enumerable.Range(1, 50);

            //use extension methods
            var queryA = numbers.Select(x => x); //performs no actions

            //use query expression (equivalent to extension method option above)
            var queryB = from n in numbers select n;

            //functional way to turn it into a list
            var resultsB = queryB.ToList();
        }

        public void SelectWithNumberTransform() {
            //functional Map == LINQ Select
            //perform an action
            var numbers = Enumerable.Range(1, 50);
            var queryA = numbers.Select(x => x * 10);
            var queryB = from n in numbers
                         select n * 10;

            var resultsA = queryA.ToList();
            var resultsB = queryB.ToList();

        }
    }
       
}
