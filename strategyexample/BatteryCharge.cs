﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyexample
{
    public class BatteryCharge : ChargeBehavior
    {
        public void Charge(ref int chargepercent)
        {
            Console.WriteLine("Sometimes I need to change batteries!");
            chargepercent += 100;
            if (chargepercent > 100) chargepercent = 100;
        }
    }
}
