using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyexample
{
    public class SportsCar : Car
    {
        public SportsCar()
        {
            driveBehavior = new ManualDrive();
            beepBehavior = new HonkBeep();
            chargeBehavior = new GasolineCharge();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a sports car, I'm {0} km away from home and have {1}% battery left.", position, chargepercent);
        }
    }
}
