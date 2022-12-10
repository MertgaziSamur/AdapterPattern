using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public abstract class HomeAppliance : Appliance
    {
        protected TurkishPowerSource powerSource;
        public void setPowerSource(TurkishPowerSource powerSource)
        {
            this.powerSource = powerSource;
        }

        public void start()
        {
            throw new NotImplementedException();
        }

        public void stop()
        {
            throw new NotImplementedException();
        }
    }
}
