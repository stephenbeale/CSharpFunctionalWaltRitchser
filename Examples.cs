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
        }
    }
}
