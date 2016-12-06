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
        public int usePump()
        {
            float cashAmount = 0;
            float amountOfGas =0;
            int typeOfGas =0, typeOfPayment = 0;
            bool loopEnd = false, hold;

            while(loopEnd == false)
            {
                loopEnd = true;
                Console.Out.WriteLine("Are you using a credit or debit card (1 for credit, 2 for debit):");
                typeOfPayment = Console.Read();
                Console.Out.WriteLine("Enter the type of gas you would like (1 for regular, 2 for premium, 3 for super): ");
                typeOfGas = Console.Read();
                Console.Out.WriteLine("Enter the number of gallons of gas you want to pay for: ");
                amountOfGas = Console.Read();
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
