/*Author: John Houk Stephen Brikiatis
Class:  CSI-340-01
Assignment: Semester project
Date Assigned: 09/16/16
Due Date: 12/05/16

Description: This is the store class, which manages the flow of user interaction,
and moves data to the database.

Certification of Authenticity:
We certify that this assignment is entirely our own work.
*/﻿

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
        public FuelTank[] tanks { get; private set; }
        private float currentAccounts { get; set; }
        private DBInterface records { get; set; }
        public Employee[] employees { get; private set; }

        public Store()
        {
            storeID = 555;
            register = new CashRegister(this);
            tanks = new FuelTank[3];
            for (int i = 0; i < 3; i++)
                tanks[i] = new FuelTank(i);
            pumps = new FuelPump[3];
            for (int i = 1; i < 4; i++)
                pumps[i - 1] = new FuelPump(this, tanks);
            currentAccounts = 0;
            records = DBInterface.Instance;
            employees = new Employee[3];
            records.getEmployees(employees);
        }

        //function to receive pump payment either in cash or with card
        //hold is true if debit card was used and there is a hold on the account
        //transaction type is enumerated in pumpState
        public int receivePumpPay(float amnt, ref bool hold, int transactionType)
        {
            currentAccounts += amnt;
            if (hold)
            {
                hold = false;
                Console.WriteLine("Hold Removed");
            }

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
