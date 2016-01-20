using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class TractorBeam : Reactor, IActivate 
    {
        public int TractorBeamLevel { get; private set; }
        public TractorBeam(int PowerRate, int TractorBeamLevel) :base(PowerRate)
        {
            this.TractorBeamLevel = TractorBeamLevel;
        }

        private void GenerateTractorBeam()
        {
            TractorBeamLevel++;
        }
        private void DeactivateTractorBeam()
        {
            TractorBeamLevel--;
        }
        public void Activate()
        {
            GenerateTractorBeam();
        }

        public void Refresh()
        {
            DeactivateTractorBeam();
        }
    }
}
