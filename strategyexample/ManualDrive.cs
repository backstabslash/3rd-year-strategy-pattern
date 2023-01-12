using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyexample
{
    public class ManualDrive : DriveBehavior
    {
        public void Drive(ref int position, ref int chargepercent)
        {
            Console.WriteLine("I am manually controlled!");
            if (chargepercent > 5)
            {
                position += 5;
                chargepercent -= 5;
            }
            else Console.WriteLine("Low charge.");
        }   
    }
}
