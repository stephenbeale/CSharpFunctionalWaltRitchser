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


namespace CSharpFunctionalWaltRitchser
{
    public class Examples
    {

        public void DoWork()
        {
            var currentProduct = new Product(productName: "Microphone", retailPrice: 200M);
            var salePriceA = GetProductPrice(product: currentProduct, quantity: 12, isPremiumCustomer: true);

            //var salePriceB = GetProductPriceByExpression(product: currentProduct, quantity: 12, isPremiumCustomer: true);
        }

        #region If statements - poor practice

        public decimal GetProductPrice(Product product, int quantity, bool isPremiumCustomer)
        {
            decimal discountAmount = 0;
            if(quantity > 10)
            {
                discountAmount += .15M;
            }
            if(isPremiumCustomer)
            {
                discountAmount += .05M;
            }
            return product.RetailPrice * (1 - discountAmount);
        }

        #endregion

        #region Expression version - my attempt

        //Uses a double ternary in lieu of if statements
        public decimal GetProductPriceExpression(Product product, int quantity, bool isPremiumCustomer)
        {
            decimal discountAmount = (quantity > 10 ? .15M : 0) + (isPremiumCustomer ? 0.05M : 0);
            return product.RetailPrice * (1 - discountAmount);
        }

        #endregion

        #region Expression examples
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

        #endregion

        #region Types
        public enum StandardColours
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Indigo,
            Violet,
            Black,
            White
        }

        public class Product
        {
            public string ProductName { get; set; }
            public decimal RetailPrice { get; set; }

            public Product(string productName, decimal retailPrice)
            {
                ProductName = productName;
                RetailPrice = retailPrice;
            }            
        }
        #endregion
    }
}
