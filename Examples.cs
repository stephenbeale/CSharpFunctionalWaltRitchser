using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFunctionalWaltRitchser
{
    public class Examples
    {
        public decimal CalcDiscount(decimal amount, decimal discountRate)
        {
            //Functional because return is based entirely on input parameters.
            return amount * (1 - discountRate);
        }
    }
}
