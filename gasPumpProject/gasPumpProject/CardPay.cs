/*Author: John Houk Stephen Brikiatis
Class:  CSI-340-01
Assignment: Semester project
Date Assigned: 09/16/16
Due Date: 12/05/16

Description: This code is a state of pumpState, used if the user selects to pay with a credit card.

Certification of Authenticity:
We certify that this assignment is entirely our own work.
*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    class CardPay : PumpState
    {
        FuelPump parent;

        //implemented to satisfy abstract class requirements
        //should only be called if there is an error
        public override void usePump()
        {
            Console.WriteLine("ERR: Wrong State");
            return;
        }
        public override float usePump(int paymentType, int typeOfGas, float amountOfGas)
        {
            bool hold;
            float cashAmount;
            switch (typeOfGas)
            {
                case 1:
                    cashAmount = amountOfGas * parent.getPrice(typeOfGas);
                    break;
                case 2:
                    cashAmount = amountOfGas * parent.getPrice(typeOfGas);
                    break;
                case 3:
                    cashAmount = amountOfGas * parent.getPrice(typeOfGas);
                    break;
                default:
                    Console.Out.WriteLine("That is not a type of fuel, choose a type of gas.");
                    cashAmount = 0;
                    break;
            }
            if (paymentType == 1)
                hold = false;
            else
            {
                hold = true;
                Console.WriteLine("Hold Placed");
            }
            Console.WriteLine("You bought {0} gallons of gas, for {1} dollars",
                               amountOfGas, cashAmount);
            amountOfGas = parent.getCurrentGas(typeOfGas) - amountOfGas;
            parent.setTankStatusGas(amountOfGas, typeOfGas);
            parent.store.receivePumpPay(cashAmount, ref hold, (int)pumpState.card);
            return 0;
        }
        public CardPay(FuelPump pump)
        {
            parent = pump;
        }
    }
}
