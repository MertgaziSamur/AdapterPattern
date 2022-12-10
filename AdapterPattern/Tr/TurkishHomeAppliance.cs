using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TurkishHomeAppliance : HomeAppliance
    {
        protected string name;
        public TurkishHomeAppliance(string name)
        {
            this.name = name;
        }

        public void start()
        {
            Console.WriteLine("TurkishHomeAppliance " + name + "is starting!");
            powerSource.turnOn();
        }

        public void stop()
        {
            Console.WriteLine("TurkishHomeAppliance " + name + "stoping!");
            powerSource.turnOf();
        }
    }
}
