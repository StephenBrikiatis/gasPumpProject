using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    class Store
    {
        private int storeID { set; get; }
        public cashRegister register { private set; get; }
        public FuelPump[] pumps { private set; get; }
        private float currentAccounts { set; get; }
        private readonly DBInterface records;
        Employee[] employees;

        public int receivePumpPay(float amnt, ref bool hold, int transactionType)
        {
            currentAccounts += amnt;
            if (hold)
                hold = false;

            return (int)function.success;
        }
    }
}