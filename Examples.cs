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

        public DateTime GetCurrentTimeRoundedUpToCustomMinuteInterval(int interval)
        {
            var currentTime = DateTime.Now;
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
    }
}
