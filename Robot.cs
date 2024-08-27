using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFunctionalWaltRitchser
{
    public class Robot
    {
        public Robot(string name, int batteryLevel)
        {
            this.RobotName = name;
            this.BatteryLevel = batteryLevel;
        }

        public string RobotName { get; set; }
        public string TeamName { get; set; }
        public int Weight { get; set; }
        public int Speed { get; set; }
        public int Strength { get; set; }
        public int Endurance { get; set; }
        public int BatteryLevel { get; set; }
        public object Value1 { get; }
        public object Value2 { get; }
    }

    //Lack of constructor here is 'parameterless' constructor, so can use Weight = etc. when instantiating.
}
