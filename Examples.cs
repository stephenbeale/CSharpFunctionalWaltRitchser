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
            //Builder
            //Builder is a sub-class of Colour, hence same colour and chaining this way
            //returning 'this' on the various setter methods also allows the chaining here.
            Colour colour1 = new Colour.Builder().Create(); //default
            Colour colour2 = new Colour.Builder().Red(127).Create(); //red only
            Colour colour3 = new Colour.Builder().Green(45).Alpha(255).Create(); // green and alpha
            Colour colour4 = new Colour.Builder().Blue(1).Create();

            var greenValue = colour3.Green;

            //Can't set it
            //colour2.Red = 0;

            //But existing methods still work.
            Colour lightenedColour = colour3.Lighten(22);

        }
    }
}
