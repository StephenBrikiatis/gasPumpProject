using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    class Store
    {
        private int storeID;
        public cashRegister register { get; private set; }
        public FuelPump[] pumps { get; private set; }
        private float currentAccounts { get; set; }
        private DBInterface records { get; set; }
        public Employee[] employees { get; private set; }

        //function to receive pump payment either in cash or with card
        //hold is true if debit card was used and there is a hold on the account
        //transaction type is enumerated in pumpState
        public int receivePumpPay(float amnt, ref bool hold, int transactionType)
        {
            currentAccounts += amnt;
            if (hold)
                hold = false;
            if (transactionType == (int)pumpState.card)
                DBInterface.cardTransaction(amnt, currentAccounts);
            else
                DBInterface.cashTransaction(amnt, currentAccounts);

            return (int)function.success;
        }

        //calls pay for fuel on the appropriate register for the store
        public int prePayPump(float amnt, int pumpID){
            return register.payForFuel(pumpID, amnt);
        }

        //initial setup for demo, should be called from either UI or main
        public void openStore
        {

        }
    }
}