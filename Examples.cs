using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace CSharpFunctionalWaltRitchser
{
    public class Examples
    {
        /*Expressions can be:
         * - literal value
         * - method invocation
         * - operator and its operands
         * - simple name e.g. name of variable, type member, method parameter, namespace or type.
         * 
         */

        public void ExamplesOfExpressions()
        {
            /*
             * An expression yields a value
             * and can be used in places where a value is expected
             */

            //variables hold the value
            string stringValue;
            int intValue;

            intValue = Int32.MaxValue;

            // literals are expressions

            stringValue = "hello";
            intValue = 909;

            // variables are expressions
            string sayHello = stringValue;
            int x = intValue;

            // invocations (function calls that return a value)
            var upperCaseWord = stringValue.ToUpper();
            var concatValue = $"first number{intValue}, second number{x}";

            double calculatedValue = Math.Sqrt(Math.Abs(3) + x);

            // operators and operands

            bool isBig = x > 1000;
            string isBigString = isBig ? "Big Number" : "Small number";


        }
    }
}
