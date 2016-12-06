/*Author: John Houk Stephen Brikiatis
Class:  CSI-340-01
Assignment: Semester project
Date Assigned: 09/16/16
Due Date: 12/05/16

Description: The class that manages the pump, it's states, and the fuel tank.

Certification of Authenticity:
We certify that this assignment is entirely our own work.
*/

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

        public FuelPump(Store parentStore, FuelTank[] tanks)
        {
            store = parentStore;
            state = new CardPay(this);
            inUse = false;
            prepaid = 0;
            tankStatus = tanks;
        }

        //use pump as a customer, branches based on payment type
        public void customerUP(int paymentType, int typeOfFuel, float amount)
        {
            //if credit or debit were used to operate the pump
            if (paymentType != 0)
                state.usePump(paymentType, typeOfFuel, amount);
            //else, it's a cash payment, the register needs to be involved
            else
            {
                store.register.payForFuel(this, amount);
                state.usePump(paymentType, typeOfFuel, amount);
            }
        }

        //use pump as an employee
        public void employeeUP()
        {
            setState((int)pumpState.diagnostics);
            state.usePump();
        }

        //update the amount of fuel in a tank
        public void setTankStatusGas(float amount, int type)
        {
            tankStatus[type].setGallons(amount);
        }

        //check the amount of fuel in a tank
        public float getCurrentGas(int tank)
        {
            return tankStatus[tank].getGallons();
        }

        //get the price per gallon for fuel in a given tank
        public float getPrice(int tank)
        {
            return tankStatus[tank].getPrice();
        }

        //set the pump to the desired state
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
