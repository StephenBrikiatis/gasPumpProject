using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gasPumpProject
{
    //This class handles all database transaction (which are actually just fileIO for the demo)
    //it is a singleton
    class DBInterface
    {
        //this is the only instance of DBInterface that will ever be instantiated
        private static DBInterface instance;

        //This is the public facing getter for the single interface
        public static DBInterface Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBInterface();
                return instance;
            }
        }

        System.IO.StreamWriter accounts;
        System.IO.StreamReader readEmployees;

        //Constructor, all initial values are hardcoded because this is just a demo standin
        //for what would be an actual database connection in a final product
        private DBInterface()
        {
            accounts = new System.IO.StreamWriter("accounts.txt", true);
            readEmployees = new System.IO.StreamReader("employees.txt");
        }

        //function for recording transactions in the accounts file
        //they are stored as type CASH or CARD, amount, new account balance
        public void transaction(float amnt, float currentAccounts, int transactionType)
        {
            string cashOrCard = null;
            if( transactionType == (int)pumpState.card )
                cashOrCard = "CARD";
            else
                cashOrCard = "CASH";
            accounts.WriteLine("{0}, {1}, {2}", cashOrCard, amnt, currentAccounts);
            return;
        }

        public void getEmployees(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee( Convert.ToInt32(readEmployees.ReadLine()) );
            }
        }
    }
}
