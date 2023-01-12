using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyexample
{
    public abstract class Car
    {
        public DriveBehavior driveBehavior;
        public BeepBehavior beepBehavior;
        public ChargeBehavior chargeBehavior;
        protected int position = 0, chargepercent = 50;
        public abstract void Display();
        public void Perform()
        {
            PerformDriving();
            PerformCharging();
            PerformSignal();
        }
        public void PerformCharging()
        {
            chargeBehavior.Charge(ref chargepercent);
        }
        public void PerformDriving()
        {
            driveBehavior.Drive(ref position, ref chargepercent);
        }
        public void PerformSignal()
        {
            beepBehavior.Signal();
        }
        public void SetChargeBehavior(ChargeBehavior chb)
        {
            chargeBehavior = chb;
        }
        public void SetControlBehavior(DriveBehavior drb)
        {
            driveBehavior = drb;
        }
        public void SetBeepBehavior(BeepBehavior beb)
        {
            beepBehavior = beb;
        }
    }
}
