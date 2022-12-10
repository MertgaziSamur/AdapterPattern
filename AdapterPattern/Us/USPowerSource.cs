using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface USPowerSource
    {
        public void providePowerAt110V();
        public void pushSwitch();
    }
}
