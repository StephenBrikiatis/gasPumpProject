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
        public CashRegister register { get; private set; }
        public FuelPump[] pumps { get; private set; }
        private float currentAccounts { get; set; }
        private DBInterface records { get; set; }
        public Employee[] employees { get; private set; }

        public Store()
        {
            storeID = 555;
            register = new CashRegister(this);
            pumps = new FuelPump[3];
            currentAccounts = 0;
            records = DBInterface.Instance;
            records.getEmployees(employees);
        }

        //function to receive pump payment either in cash or with card
        //hold is true if debit card was used and there is a hold on the account
        //transaction type is enumerated in pumpState
        public int receivePumpPay(float amnt, ref bool hold, int transactionType)
        {
            currentAccounts += amnt;
            if (hold)
                hold = false;

            records.transaction(amnt, currentAccounts, transactionType);
            return (int)function.success;
        }

        //initial setup for demo, should be called from main
        public void openStore()
        {
            register.employeeLogin(employees[1]);
            return;
        }
    }
}