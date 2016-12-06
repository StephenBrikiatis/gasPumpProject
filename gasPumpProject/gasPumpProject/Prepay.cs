/*Author: John Houk Stephen Brikiatis
Class:  CSI-340-01
Assignment: Semester project
Date Assigned: 09/16/16
Due Date: 12/05/16

Description: This class is a state for pumpState that is used when the user pays with cash.

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
    class Prepay : PumpState
    {
        FuelPump parent;
        public Prepay(FuelPump pump)
        {
            parent = pump;
        }
        public override void usePump()
        {
            Console.WriteLine("ERR: Wrong State (Prepay)");
            parent.setState((int)pumpState.card);
            return;
        }

        //in the case of prepay, paymentType is ignored, the amount of gas dispensed is displayed
        public override float usePump(int paymentType, int typeOfGas, float amount)
        {
            Console.WriteLine("You paid {0}, you bought {1} gallons of gas",
                              amount, amount / parent.getPrice(typeOfGas));
            parent.setState((int)pumpState.card);
            parent.prepaid = 0;
            return 0;
        }
    }
}
