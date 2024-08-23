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
        public void UseEnumerablePipeline()
        {
            //similar to LINQ versions
            var numbers = Enumerable.Range(1, 120);
            numbers.ToList().ForEach(item => Console.WriteLine(item));
            var selectedNumbers = Enumerable.Select(source: numbers, selector: x => x + x);

            //evaluated from right to left
            var resultA = numbers.WhereAsPipeline(x => x % 5 == 0);
            var resultB = numbers.WhereAsPipeline(x => x % 12 == 0).TransformAsPipeline(x => x * 10).ToList();

            var resultC = resultB.SkipByAsPipeline(6).ToList();
        }
    }

    public static class Extensions
    {
       public static IEnumerable<T> WhereAsPipeline<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            foreach (T item in source)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> TransformAsPipeline<T>(this IEnumerable<T> source, Func<T, T> transformer)
        {
            //execute this code for every item in the enumerable

            foreach (T item in source)
            {
                yield return item;
            }
        }

        public static IEnumerable<T> SkipByAsPipeline<T>(this IEnumerable<T> source, int numberToSkip)
        {
            using (IEnumerator<T> e = source.GetEnumerator())
            {
                while (numberToSkip > 0 && e.MoveNext()) numberToSkip--;
                if (numberToSkip <= 0)
                {
                    while (e.MoveNext()) yield return e.Current;
                }
            }
        }

        public static T PerformOperation<T>(this T value, Func<T, T> performer) where T : struct
        {
            return performer(value);
        }
    }
}
