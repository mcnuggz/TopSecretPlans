using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Reactor
    {
        public int PowerRate { get; private set; }
        Reactor(int PowerRate)
        {
            this.PowerRate = PowerRate;
        }
        public int GeneratePower()
        {
			PowerRate++;
            return PowerRate;
        }
    }
}
