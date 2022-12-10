using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface Appliance
    {
        public void setPowerSource(TurkishPowerSource powerSource);
        public void start();
        public void stop();
    }
}
