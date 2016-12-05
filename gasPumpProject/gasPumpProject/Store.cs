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
        private readonly DBInterface records { get; set; }
        public Employee[] employees { ;

        public int receivePumpPay(float amnt, ref bool hold, int transactionType)
        {
            currentAccounts += amnt;
            if (hold)
                hold = false;
            
        }
    }
}