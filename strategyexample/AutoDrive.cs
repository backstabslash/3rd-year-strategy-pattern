using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyexample
{
    public class AutoDrive : DriveBehavior
    {
        public void Drive(ref int position, ref int chargepercent)
        {
            Console.WriteLine("I'm on autopilot!");
            if (chargepercent > 3)
            {
                position += 3;
                chargepercent -= 3;
            }
            else Console.WriteLine("Low charge.");
        }
    }
}
