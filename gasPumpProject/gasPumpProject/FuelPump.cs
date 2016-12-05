using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{

    class FuelPump
    {
        public Store store;
        PumpState state;
        bool inUse;
        int prepaid;
        FuelTank[] tankStatus = new FuelTank[3];

        public void customerUP()
        {

        }

        public void employeeUP()
        {

        }

        public void usePump()
        {

        }

        public void setTankStatusGas(float amount, int type)
        {
            tankStatus[type].setGallons(amount);
        }

        public float getCurrentGas(int tank)
        {
            return tankStatus[tank].getGallons();
        }

        public float getPrice(int tank)
        {
            return tankStatus[tank].getPrice();
        }
    }
}
