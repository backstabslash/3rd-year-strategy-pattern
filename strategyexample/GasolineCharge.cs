using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyexample
{
    public class GasolineCharge : ChargeBehavior
    {
        public void Charge(ref int chargepercent)
        {
            Console.WriteLine("Sometimes I need to replenish my gas supplies!");
            chargepercent += 40;
            if (chargepercent > 100) chargepercent = 100;
        }
    }
}
