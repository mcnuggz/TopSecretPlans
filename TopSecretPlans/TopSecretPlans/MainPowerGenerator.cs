using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
	public class MainPowerGenerator : Reactor
	{
		public  int startupPowerLevel {
			private set
			{
				startupPowerLevel = value;
			}
			get
			{
				return startupPowerLevel;
			}

		};
		public MainPowerGenerator(int PowerRate, int startupPowerLevel)
			: base(PowerRate)
		{
			this.startupPowerLevel = startupPowerLevel;
		}
	}
}
