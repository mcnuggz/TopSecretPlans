using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class IonDriveReactor : Reactor, IActivate 
    {

        private int IonDriveRate = 4;
        private int IonCharge = 0;

        public IonDriveReactor(int PowerRate) : base(PowerRate) 
        {
           
        }

        public void Activate()
        {
            ChargeIonDrive();
        }

        public void Refresh()
        {
            CoolDownIonDrive();
        }

        private int ChargeIonDrive()
        {
            return IonCharge = PowerRate * IonDriveRate;            
        }
        private int CoolDownIonDrive()
        {
            return IonCharge = 0;
        }
    }
}
