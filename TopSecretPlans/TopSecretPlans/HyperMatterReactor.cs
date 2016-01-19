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

        public HyperMatterReactor(int PowerRate) : base(PowerRate)
        {

        }
        public int GenerateHyperMatter()
        {
            HyperMatterAmount = HyperSpaceEnergy / HyperMatterRate * StellarFuel;
            return HyperMatterAmount;
        }

    }
    }

