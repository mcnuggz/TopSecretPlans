using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Reactor : IActivate
    {
        public int PowerRate { get; private set; }
        private int PowerSupply = 0;
        private int InitialPowerPercent = 0;
        private int MaxPowerPercent = 100;

        public Reactor(int PowerRate)
        {
            this.PowerRate = PowerRate;
        }
        private int GeneratePower()
        {
            if(InitialPowerPercent <= MaxPowerPercent)
            {
                Console.WriteLine("Charging...");
                PowerRate++;
                if (InitialPowerPercent == MaxPowerPercent)
                {
                    Console.WriteLine("Fully charged.");
                }             
            }
            return PowerSupply;
        }
        private int ShutDown()
        {
            while(PowerSupply != InitialPowerPercent)
            {
                PowerSupply--;
                Console.WriteLine("Shutting down...");
            }
            return PowerSupply;
        }

        void IActivate.Activate()
        {
            GeneratePower();
        }

        void IActivate.Refresh()
        {
           ShutDown();
        }
    }
}
