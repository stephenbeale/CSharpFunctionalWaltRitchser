using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFunctionalWaltRitchser
{
    public sealed class Colour
    {
        //Obsolete - don't use this
        public byte Orange { get; private set; }

        //Better but more verbose
        //Backing field which must be set in the constructor as there is no setter
        private readonly byte _purple { get; set; }

        public byte Purple { 
            get { return _purple; }
        }

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
        }
    }
}
