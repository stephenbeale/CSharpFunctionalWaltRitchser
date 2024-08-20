using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace CSharpFunctionalWaltRitchser
{
    public class Examples
    {
       public void DoWork()
        {
            //Instantiate immutable colour class 

            //Can't do as he's done with Immutable.Colour - this is not possible anymore
            var myColour1 = new Colour(red: 127, green: 23, blue: 255);
        }
    }
}
