using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    class Store
    {
        int storeID;
        cashRegister register;
        FuelPump[] pumps;
        float currentAccounts;
        DBInterface records;
        Employee[] employees;

        public int receivePumpPay(float amnt, ref bool hold, int transactionType)
        {
            currentAccounts += amnt;
            if (hold)
                hold = false;
            
        }
    }
}