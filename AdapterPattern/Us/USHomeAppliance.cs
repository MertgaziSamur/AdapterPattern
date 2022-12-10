using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class USHomeAppliance
    {
        private string name;
        private USPowerSource usPowerSource;

        public USHomeAppliance(string name)
        {
            this.name = name;
        }
        public void setPowerSource(USPowerSource uSPowerSource)
        {
            this.usPowerSource = usPowerSource;
        }
        public void start()
        {
            Console.WriteLine("USHomeApplicance " + name + " is turning on!");
            usPowerSource.pushSwitch();
        }
        public void stop()
        {
            Console.WriteLine("USHomeApplicance " + name + " turning off!");
            usPowerSource.pushSwitch();
        }
    }
}
