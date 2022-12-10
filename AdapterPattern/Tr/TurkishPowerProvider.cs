using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TurkishPowerProvider : TurkishPowerSource
    {
        public TurkishPowerProvider()
        {
            Console.WriteLine("TurkishPowerProvider is up and running.");
        }
        public void providePowerAt220V()
        {
            Console.WriteLine("I provide electricity at 220V. Be careful, there may be some casual interruptions!");
        }

        public void turnOf()
        {
            Console.WriteLine("TurkishPowerProvider started to provide electricity.");
        }

        public void turnOn()
        {
            Console.WriteLine("TurkishPowerProvider stopped to provide electricity.");
        }
    }
}
