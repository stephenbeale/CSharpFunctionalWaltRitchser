using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFunctionalWaltRitchser
{
    public class Examples
    {
       public void DoWork()
        {
            //Immutable types internal state is not changeable after creation
            DateTime dt1, dt2;

            //Set some properties in the constructor
            dt1 = new DateTime(year: 2025, month: 10, day: 26);

            //All properties are read-only after initialisation
            //or think of them as 'write-once'

            int day = dt1.Day; //we can read this value
            //dt1.Day = 27; // we cannot change this via property as it is read-only

            //But what about when we do need to change the instance?
            //For example, add 3 days to the existing date.
        }
    }
}
