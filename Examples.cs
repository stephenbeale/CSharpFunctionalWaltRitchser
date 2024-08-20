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
        //Global variable = mutatable across functions, so a problem 
        private int _counter = 0;
      
        private List<int> _numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

        //Now pure  - debug looking at list that goes in and list that comes out.

        public ImmutableList<int> AddNumbersToList(ImmutableList<int> inputList)
        {
            //Now returns a new list with 5 items, so no side effect
            return inputList.Add(2);            
        }
    }
}
