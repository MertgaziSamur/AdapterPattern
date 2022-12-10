using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface TurkishPowerSource
    {
        public void providePowerAt220V();
        public void turnOn();
        public void turnOf();
    }
}
