using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            USPowerSource usPowerSource = new USPowerProvider();
            USTurkishPowerAdapter uSTurkishPowerAdapter = new USTurkishPowerAdapter(usPowerSource);

            Console.WriteLine();

            Appliance shaver = new TurkishHomeAppliance("Shaver");
            shaver.setPowerSource(uSTurkishPowerAdapter);
            shaver.start();
            shaver.stop();

            Console.WriteLine();
        }
    }
}
