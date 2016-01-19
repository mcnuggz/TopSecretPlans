using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class TractorBeam : Reactor
    {
        public int TractorBeamLevel;
        public Tractorbeamgeneratortower(int powerrate)
        {
            TractorBeamLevel = powerrate * 5;
            
        }

        public void GenerateTractorBeam()
        {
            TractorBeamLevel++;
        }

        public void CreateForce(int power, int direction)
        {
            
        }
    }
}
