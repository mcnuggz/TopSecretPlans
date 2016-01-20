using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
	public class MainPowerGenerator : Reactor, IActivate
	{
        public int startupPowerLevel = 0;
        private int maxPower;

		public MainPowerGenerator(int PowerRate, int startupPowerLevel, int maxPower) : base(PowerRate)
		{
			this.maxPower = maxPower;
			this.startupPowerLevel = startupPowerLevel;
		}

        public void Activate()
        {
            CanPowerUp();
            isAtMaxPower();
            isOverHeated();
        }

        public void Refresh()
        {
            maxPower = 0;
        }

        private bool CanPowerUp()
		{
			if (startupPowerLevel >= PowerRate)
			{
				return true;	
			} else
			{
				return false;
			}
		}
		private bool isAtMaxPower()
		{
			if (maxPower == PowerRate)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private bool isOverHeated()
		{
			if (PowerRate > maxPower)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
