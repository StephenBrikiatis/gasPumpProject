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
        FuelPump[] pumps = new FuelPump[2];
        float currentAccounts;
        DBInterface records;
        Employee[] employees = new Employee[5];

        public int receivePumpPay(float amnt, bool hold, int transactionType)
        {
            currentAccounts += amnt;
            if (hold)
                hold = false;
            
        }

        public FuelPump getPump(int pumpNumber)
        {
            return pumps[pumpNumber];
        }
    }
}