using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class HyperMatterReactor : Reactor, IActivate
    {
        private int HyperMatterRate = 3;
        private int HyperSpaceEnergy { get; set; }
        private int StellarFuel { get; set; }
        private int HyperMatterAmount;

        public HyperMatterReactor(int HyperMatterRate, int HyperSpaceEnergy, int StellarFuel, int PowerRate)
            :base(PowerRate)
        {
            this.HyperMatterRate = HyperMatterRate;
            this.HyperSpaceEnergy = HyperSpaceEnergy;
            this.StellarFuel = StellarFuel;
            
        }
        private int GenerateHyperMatter()
        {
            return HyperMatterAmount = HyperSpaceEnergy / HyperMatterRate * StellarFuel;
        }
        private int ShutDown()
        {
            return HyperMatterAmount--;
        }
        public void Activate()
        {
            GenerateHyperMatter();
        }

        public void Refresh()
        {
            ShutDown();
        }
    }
}    
 

