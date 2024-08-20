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
        public decimal CalcDiscount(decimal amount, decimal discountRate)
        {
            //Functional because return is based entirely on input parameters.
            return amount * (1 - discountRate);
        }

        //Adding startTime parameter here makes this pure
        public DateTime GetCurrentTimeRoundedUpToCustomMinuteInterval(int interval, DateTime startTime)
        {
            var currentTime = startTime;
            var minuteSpan = TimeSpan.FromMinutes(interval).Ticks;

            if (currentTime.Ticks % minuteSpan == 0)
            {
                return currentTime;
            }
            else
            {
                return new DateTime((currentTime.Ticks / minuteSpan + 1) *
                    minuteSpan);
            }
        }

        public void UpdateByTwo()
        {
            _counter += 2;
        }
        public void UpdateByFive()
        {
            _counter += 5;
        }

        #region List as shared state
        private void WorkWithList() { 
            var countA = _numbers.Count;
            //AddNumbersToList();
            var countB = _numbers.Count;
        }

        private List<int> _numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

        //Not changing list BUT it is changing content of list which is a side effect, hence impure.

        public void AddNumbersToList(ImmutableList<int> inputList)
        {
            //Still a side effect as changes contents of the list
            inputList.Add(2);
            inputList.Add(4);
        }

        //Pure function - not doing anything with state, doing everything locally, so no side effects.
        //Still pure with list as input - 
        public int TotalTheNumbers(ImmutableList<int> inputList)
        {
            int total = 0;
            foreach (int number in inputList)
            {
                total += number;
            }
            return total;
        }
        #endregion       

        #region 2. Don't mutate input arguments 

        public void DoWork()
        {
            //Using immutable list type that help with this.
            //Immutable types are thread-safe
            ImmutableList<int> numbersList;
            numbersList = ImmutableList<int>.Empty;
            numbersList = ImmutableList.Create<int>(1,3,5,7);
            AddNumbersToList(numbersList);
            var total = TotalTheNumbers(numbersList);
            Console.WriteLine(total);
        }

        //This is a pure function
        public void WorkingWithCounter()
        {
            int startNumber = 10;
            int newNumber = IncrementByTwo(startNumber);
            newNumber = IncrementByFive(newNumber);
        }
        public int IncrementByFive(int originalNumber)
        {
            return originalNumber + 5;
        }

        public int IncrementByTwo(int originalNumber)
        {
            return originalNumber + 2;
        }

        #endregion
    }
}
