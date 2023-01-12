using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyexample
{
    public class RadioDrive : DriveBehavior
    {
        public void Drive(ref int position, ref int chargepercent)
        {
            Console.WriteLine("I'm on radio control!");
            if (chargepercent > 2)
            {
                position += 1;
                chargepercent -= 2;
            }
            else Console.WriteLine("Low charge.");
        }
    }
}
