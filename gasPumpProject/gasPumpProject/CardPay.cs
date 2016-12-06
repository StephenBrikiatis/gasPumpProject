using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    class CardPay
    {
        FuelPump parent;
        public int usePump(int paymentType, int typeOfGas, float amountOfGas)
        {
            bool hold;

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
                        loopEnd = false;
                        break;
                }

            if(typeOfPayment == 1)
            {
                hold = false;
            }
            else
            {
                hold = true;
            }

            amountOfGas = parent.getCurrentGas(typeOfGas) - amountOfGas;

            parent.setTankStatusGas(amountOfGas, typeOfGas);
            parent.store.recievePumpPay(cashAmount, ref hold, pumpState.card);
            return 0;
        }
    }
}
