using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyexample
{
    public class ElectroCharge : ChargeBehavior
    {
        public void Charge(ref int chargepercent)
        {
            Console.WriteLine("Sometimes I need to be plugged into an outlet!");
            chargepercent += 40;
            if (chargepercent > 100) chargepercent = 100;
        }
    }
}
