using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyexample
{
    public interface DriveBehavior
    {
        public void Drive(ref int position, ref int chargepercent);
    }
}
