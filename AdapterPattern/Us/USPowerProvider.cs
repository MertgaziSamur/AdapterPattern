using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class USPowerProvider : USPowerSource
    {
        private bool on;
        public USPowerProvider()
        {
            Console.WriteLine("USPowerProvider is up and running.");
        }
        public void providePowerAt110V()
        {
            Console.WriteLine("USPowerProvider provides electricity at 110V!");
        }

        public void pushSwitch()
        {
            if (!on)
            {
                on = true;
                Console.WriteLine("USPowerProvider started to provide electricity.");
            }
            else
            {
                on = false;
                Console.WriteLine("USPowerProvider stopped to provide electricity.");
            }
        }
    }
}
