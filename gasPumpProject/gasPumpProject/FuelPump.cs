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
        public bool inUse { get; set; }
        public float prepaid { get; set; }
        FuelTank[] tankStatus = new FuelTank[3];

        public void customerUP(int paymentType, int typeOfFuel, float amount)
        {
            //if credit or debit were used to operate the pump
            if(paymentType != 0)
                state.usePump(paymentType, typeOfFuel, amount);
            //else, it's a cash payment, the register needs to be involved
            else
                store.register.payForFuel(this, amount);
        }

        public void employeeUP()
        {
            setState((int)pumpState.diagnostics);
            state.usePump();
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
                    state = new CardPay(this);
                    break;
                case (int)gasPumpProject.pumpState.cash:
                    state = new Prepay(this);
                    break;
                case (int)gasPumpProject.pumpState.diagnostics:
                    state = new Diagnostic(this);
                    break;
            }
            return;
        }
    }
}
