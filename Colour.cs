using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFunctionalWaltRitchser
{
    //Simulate an RGB colour class
    public sealed class Colour
    {
        /*
         * From C# 6 on, you can create read-only automatically-implemented properties:
         * this property can only be assigned in a constructor
         */
        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; }
        

        //This is in lieu of setters
        public Colour(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            IsWhite = (Red == 255 && Green == 255 && Blue == 255);
        }

        //ToString as a pure function
        public override string ToString()
        {
            return $"Red: {Red}, Green: {Green}, Blue: {Blue}";
        }

        public bool IsBlack()
        {
            //instance methods must be pure
            return (Red == 0 && Green == 0 && Blue == 0);
        }

        //OR Implement as a property - but must decide where to put the expression (in constructor OR here in getter)

        public bool IsWhite { get; }

        public Colour Lighten(byte lightenBy)
        {
            //+ so it can only become lighter
            //Min value must be what it comes in as, so it can't get lighter
            var redValue = (byte)Math.Clamp(value: Red + lightenBy, min: Red, max: Byte.MaxValue);
            var greenValue = (byte)Math.Clamp(value: Green + lightenBy, min: Green, max: Byte.MaxValue);
            var blueValue = (byte)Math.Clamp(value: Blue + lightenBy, min: Blue, max: Byte.MaxValue);

            return new Colour(redValue, greenValue, blueValue);
        }

        public Colour Darken(byte darkenBy)
        {
            //so it can only become lighter
            //Max. value must be what it comes in as, so can't get lighter
            var redValue = (byte)Math.Clamp(value: Red - darkenBy, min: Byte.MinValue, max: Red);
            var greenValue = (byte)Math.Clamp(value: Green - darkenBy, min: Byte.MinValue, max: Green);
            var blueValue = (byte)Math.Clamp(value: Blue - darkenBy, min: Byte.MinValue, max: Blue);

            return new Colour(redValue, greenValue, blueValue);
        }

    }
}
