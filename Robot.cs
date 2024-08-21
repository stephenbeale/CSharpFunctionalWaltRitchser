using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFunctionalWaltRitchser
{
    public class Robot
    {
        public string RobotName { get; set; }
        public string TeamName { get; set; }
        public int Weight { get; set; }
        public int Speed { get; set; }
        public int Strength { get; set; }
        public int Endurance { get; set; }
    }

    //Lack of constructor here is 'parameterless' constructor, so can use Weight = etc. when instantiating.
}
