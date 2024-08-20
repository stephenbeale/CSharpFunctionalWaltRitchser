using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpFunctionalWaltRitchser
{
    //Simulate an RGB colour class
    public sealed class Colour
    {
        /*
         * Use a builder to create new colour because it's flexible 
         * i.e. you don't have to write multiple constructors when using optional arguments
         * with 4 optional args, might need 15 constructors!
         */
        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; }
        public byte Alpha { get; }


        //This is in lieu of setters
        private Colour(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
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
            //Use builder here
            var newColour = new Colour.Builder().Red(redValue).Green(greenValue).Blue(blueValue).Alpha(this.Alpha).Create();

            return newColour;
        }

        public Colour Darken(byte darkenBy)
        {
            //so it can only become lighter
            //Max. value must be what it comes in as, so can't get lighter
            var redValue = (byte)Math.Clamp(value: Red - darkenBy, min: Byte.MinValue, max: Red);
            var greenValue = (byte)Math.Clamp(value: Green - darkenBy, min: Byte.MinValue, max: Green);
            var blueValue = (byte)Math.Clamp(value: Blue - darkenBy, min: Byte.MinValue, max: Blue);

            var newColour = new Colour.Builder().Red(redValue).Green(greenValue).Blue(blueValue).Alpha(this.Alpha).Create();

            return newColour;
        }

        public class Builder
        {
            //Set properties as private values
            private byte _red;
            private byte _green;
            private byte _blue;
            private byte _alpha;

            public Builder Red(byte red)
            {
                _red = red;
                return this;
            }
            public Builder Green(byte green)
            {
                _green = green;
                return this;
            }

            public Builder Blue(byte blue)
            {
                _blue = blue;
                return this;
            }

            public Builder Alpha(byte alpha)
            {
                _alpha = alpha;
                return this;
            }

            public Colour Create()
            {
                return new Colour(_red, _green, _blue, _alpha);
            }

        }
    }
}
