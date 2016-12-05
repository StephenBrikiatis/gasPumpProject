using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    class UI
    {
        Store store;
        
        public int cardType()
        {
            int typeOfPayment;
            Console.Out.WriteLine("Are you using a credit or debit card (1 for credit, 2 for debit):");
            typeOfPayment = Console.Read();

            return typeOfPayment;
        }
        
        public int gasSelect()
        {
            int typeOfGas;
            Console.Out.WriteLine("Enter the type of gas you would like (1 for regular, 2 for premium, 3 for super): ");
            typeOfGas = Console.Read();
            return typeOfGas;
        }

        public float getGasAmount()
        {
            float amountOfGas;
            Console.Out.WriteLine("Enter the number of gallons of gas you want to pay for: ");
            amountOfGas = Console.Read();
            return amountOfGas;
        }

    }
}
