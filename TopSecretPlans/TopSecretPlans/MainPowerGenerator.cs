using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
	public class MainPowerGenerator : Reactor
	{
		public  int totalPower {
			private set
			{
				totalPower = value;
			}
			get
			{
				return totalPower;
			}

		};
		public MainPowerGenerator(int PowerRate, int totalPower)
			: base(PowerRate)
		{
			this.totalPower = totalPower;
		}
	}
}
