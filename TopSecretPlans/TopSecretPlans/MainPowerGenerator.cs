using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
	public class MainPowerGenerator : Reactor
	{
		public MainPowerGenerator(int PowerRate)
		{
			base.PowerRate = PowerRate;
		}
	}
}
