using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class USTurkishPowerAdapter : TurkishPowerSource
    {
        private USPowerSource usPowerSource;
        private bool on;

        public USTurkishPowerAdapter(USPowerSource usPowerSource)
        {
            Console.WriteLine("\n USTurkishPowerAdapter: Converting from USPowerSource to TurkishPowerSource");
            this.usPowerSource = usPowerSource;
        }
        public void providePowerAt220V()
        {
            usPowerSource.providePowerAt110V();
            convert110To220(usPowerSource);
        }

        public void turnOf()
        {
            if (on)
            {
                usPowerSource.pushSwitch();
                on = false;
            }
        }

        public void turnOn()
        {
            if (!on)
            {
                usPowerSource.pushSwitch();
                on = true;
            }
        }
        private void convert110To220(USPowerSource usPowerSource)
        {
            Console.WriteLine("USTurkishPowerAdapter: Converting from 110V to 220V");
        }
    }
}
