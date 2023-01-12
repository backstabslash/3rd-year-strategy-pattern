using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyexample
{
    public class HonkBeep : BeepBehavior
    {
        public void Signal()
        {
            Console.WriteLine("peep peep!");
        }
    }
}
