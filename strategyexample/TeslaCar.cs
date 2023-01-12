using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyexample
{
    public class TeslaCar : Car
    {
        public TeslaCar()
        {
            driveBehavior = new AutoDrive();
            beepBehavior = new HonkBeep();
            chargeBehavior = new ElectroCharge();
        }
        public override void Display()
        {
            Console.WriteLine("I'm an electric car, I'm {0} km away from home and have {1}% charge left.", position, chargepercent);
        }
    }
}
