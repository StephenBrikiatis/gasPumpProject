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
        public float prepaid { get; set; }
        FuelTank[] tankStatus = new FuelTank[3];

        public void customerUP()
        {
            state.usePump();
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

        public void setState(int pumpState)
        {
            switch (pumpState)
            {
                case (int)gasPumpProject.pumpState.card :
                    state = new CardPay();
                    break;
                case (int)gasPumpProject.pumpState.cash:
                    state = new Prepay();
                    break;
                case (int)gasPumpProject.pumpState.diagnostics:
                    state = new Diagnostic();
                    break;
            }
            return;
        }
    }
}
