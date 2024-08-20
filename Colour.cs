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
    }
}
