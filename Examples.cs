using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

using static CSharpFunctionalWaltRitchser.Examples;

namespace CSharpFunctionalWaltRitchser
{
    public class Examples
    {

        public void DoWork()
        {
            UseLambda();
        }

        private void UseLambda()
        {
            /* easy way to represent functions is with
             * the Func<T> and Action<T> delegates
             */

            //Use variable to store a function (as delegate type)
            //If your function is short, and doesn't need to be reused
            // a Lambda expression is useful
            Func<int, int> functionVar = x => (x * 10);

            int result = functionVar(6);

            Func<int, int, bool> predicateVar = IsMultipleOf;

            bool isMultipleOfFive = predicateVar(25, 5);
            bool isMultipleOfSeven = predicateVar(25, 7);
        }

        public bool IsMultipleOf(int candidate, int multiplier)
        {
            return (candidate % multiplier) == 0;
        }

        public int GetDayAsNumber(string day)
        {
            if (Enum.TryParse(day, true, out DaysOfWeek dayEnum))
            {
                return dayEnum switch
                {
                    DaysOfWeek.Monday => 1,
                    DaysOfWeek.Tuesday => 2,
                    DaysOfWeek.Wednesday => 3,
                    DaysOfWeek.Thursday => 4,
                    DaysOfWeek.Friday => 5,
                    DaysOfWeek.Saturday => 6,
                    DaysOfWeek.Sunday => 7,
                };
            }
            return default;
        }

            public enum DaysOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    }
    
}
