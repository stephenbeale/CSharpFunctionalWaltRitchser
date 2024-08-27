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

        public void SelectProjectToAnotherType() {
            //functional Map == LINQ Select
            //perform an action
            var xValues = Enumerable.Range(1, 20);
            var yValues = Enumerable.Range(100, 20);

            //For value of x, instantiate new Ray Point, set x, leave y as 0.
            var queryA = xValues.Select(x => new RayPoint(x, 0));

            var queryB = from n in yValues
                         select new RayPoint(0, n);

            var resultsA = queryA.ToList();
            var resultsB = queryB.ToList();
        }

        public void FilterSimple()
        {
            var numbers = Enumerable.Range(1, 200);
            var queryA = numbers.Where(x => x < 20);
            //Select is optional here - don't bother!
            var queryAa = numbers.Where(x => x < 20).Select(x => x);

            //Query expression
            var queryB = from n in numbers
                         where n < 20 || n > 180
                         select n;

            var resultsA = queryA.ToList();
            var resultsAa = queryAa.ToList();
            var resultsB = queryB.ToList();
        }

        public void FilterForPrimeNumbers() { 
            Func<int, bool> isPrime = p => Enumerable.Range(2, (int)Math.Sqrt(p) -1)
                                            .All(divisor => p % divisor != 0);

            var primes = Enumerable.Range(2, 1000 * 1000)
                .Where(isPrime);

            var resultsA = primes.ToList();
        }

        public void FlattenListProperty() {
            //flattens multi-dimensional set into a single set
            // AKA SelectMany select values from a nested collection
            var brandA = new Brand { Name = "Fancy-shoes", Colours = new List<string> { "Red", "Orange" } };
            var brandB = new Brand { Name = "Lux-cars", Colours = new List<string> { "Gold", "Silver" } };
            var brandC = new Brand { Name = "Wow-electronics", Colours = new List<string> { "Black", "Blue", "Purple" } };
            List<Brand> brands = new List<Brand>();
            brands.Add(brandA);
            brands.Add(brandB);
            brands.Add(brandC);

            //this does not produces the results we want - instead it returns a separate list of colours for each item, still nested
            var resultA = brands.Select(x => x.Colours).ToList();

            //This DOES! Combines all colours found into a single, top-level list i.e. no nesting
            var resultB = brands.SelectMany(x => x.Colours).ToList();
        }

        private class Brand
        {
            public string Name { get; set; }
            public List<string> Colours { get; set; }
        }

        public void JoinExample()
        {
            //SelectMany also useful for joining similar lists

            var setA = Enumerable.Range(2, 3);
            var setB = Enumerable.Range(5, 3);

            //Horrible and confusing
            var basicSelect = setA.Select(a => setB.Select(b => $"A {a}, B:{b}"));

            //Right way
            //Take each element from setA, a, and combine with each element in setB, b, then make a new string entry for each with the interpolated string
            var basicJoin = setA.SelectMany(a => setB.Select(b => $"A:{a}, B:{b}"));

            var resultsA = basicSelect.ToList();
            var resultsB = basicJoin.ToList();
        }

        public void AggregateExample()
        {
            ImmutableList<int> setA = ImmutableList.Create(5, 4, 1, 3, 4, 9, 8, 7, 6, 2, 12, 24);
            ImmutableList<int> setB = 
                ImmutableList.Create(Enumerable.Range(1, 40).Where(x => x % 5 == 0).ToArray());

            //predefined aggreates
            var total = setA.Sum();
            var count = setB.Count();

            var highestNumber = setB.Max();

            //custom aggregate
            var multipleOf = setA.Aggregate((first, second) => first * second);

            //set the initial seed (accumulator value)
            var anotherMultiple = setA.Aggregate(100, (first, second) => first * second);
        }

        //Generic aggregate function example
        public void AggregateRobots()
        {
            var robot1 = new Robot(name: "Robot1", batteryLevel: 60);
            var robot2 = new Robot(name: "Robot2", batteryLevel: 80);
            var robot3 = new Robot(name: "Robot3", batteryLevel: 20);

            ImmutableList<Robot> robots = ImmutableList.Create(new Robot[] { robot1, robot2, robot3 });

            var lowBattery = robots.Min(x => x.BatteryLevel);
        }
    }

    public class RayPoint
    {
        public int X { get; }
        public int Y { get; }

        public RayPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
