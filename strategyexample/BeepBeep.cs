using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyexample
{
    public class BeepBeep : BeepBehavior
    {
        public void Signal()
        {
            Console.WriteLine("beep beep!");
        }
    }
}
