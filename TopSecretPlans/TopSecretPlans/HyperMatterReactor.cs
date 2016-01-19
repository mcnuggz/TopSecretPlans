using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class HyperMatterReactor : Reactor
    {
        public int HyperMatterRate = 2;
        public int HyperSpaceEnergy = 1000;
        public int StellarFuel = 124994;
        public int HyperMatterAmount;

        public HyperMatterReactor(int HyperMatterRate, int HyperSpaceEnergy, int StellarFuel, int PowerRate)
            :base(PowerRate)
        {
            this.HyperMatterRate = HyperMatterRate;
            this.HyperSpaceEnergy = HyperSpaceEnergy;
            this.StellarFuel = StellarFuel;
            HyperMatterAmount = HyperSpaceEnergy / HyperMatterRate * StellarFuel;
        }
        public int GenerateHyperMatter()
        {
            return HyperMatterAmount;
        }
    }
}    
 

