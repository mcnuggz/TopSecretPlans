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
        public TractorBeam()
        {

        }

        public void Tractorbeamgeneratortower()
        {
            TractorBeamLevel = 0;
            Console.WriteLine("The Generator is at" + TractorBeamLevel);
        }

        public void GenerateTractorBeam()
        {
            TractorBeamLevel++;
        }

        public void CreateForce(int power, int direction)
        {
            CreateForce = TractorBeamLevel + GenerateTractorBeam;
            power = 10;
            direction = right;

        }
    }
}
