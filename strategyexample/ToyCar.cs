using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyexample
{
    public class ToyCar : Car
    {
        public ToyCar()
        {
            driveBehavior = new RadioDrive();
            beepBehavior = new BeepBeep();
            chargeBehavior = new BatteryCharge();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a toy car, I'm {0} km away from home and have {1}% battery left.", position, chargepercent);
        }
    }
}
