/*Author: John Houk Stephen Brikiatis
Class:  CSI-340-01
Assignment: Semester project
Date Assigned: 09/16/16
Due Date: 12/05/16

Description: This class defines the cash register, which handles user payments made in cash
and employee logins.

Certification of Authenticity:
We certify that this assignment is entirely our own work.
*/﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cash register class, tracks which employee is logged in
//tracks transactions, time amount and employee who was logged in
//allows for prepay of fuel, employee login and logout
namespace gasPumpProject
{
    class CashRegister
    {
        private int registerID { get; set; }

        //cash in this register
        private float currentCash { get; set; }

        //0 if nobody is logged in
        private Employee currentUser;

        //store that owns this register
        private Store store;

        //called from Store.prePayPump() when a customer wants to pay cash for gas
        //updates cash in register, pump's prepay value, and state of pump (cash mode)
        //alerts store to the transaction so store can update its records
        public int payForFuel(FuelPump targetPump, float paymentAmnt)
        {
            //no account hold with cash payments
            bool hold = false;
            //cannot pay at register if no employee is logged in
            if (currentUser == null)
                return (int)function.failure;
            //update cash in register to reflect payment
            currentCash += paymentAmnt;
            //alert store to transaction so database can be updated
            store.receivePumpPay(paymentAmnt, ref hold, (int)pumpState.cash);
            //set the state of the chosen pump and the prepayment amount
            targetPump.prepaid = paymentAmnt;
            targetPump.setState( (int)pumpState.cash );
            return (int)function.success;
        }

        //function to log in a new employee
        //Requires that the previous employee released the register first
        public void employeeLogin(Employee login)
        {
            //if someone is already logged in, do not allow another user to log in.
            if (currentUser != null)
            {
                System.Console.WriteLine("User {0} is already logged in", currentUser.employeeID);
                return;
            }
            currentUser = login;
            System.Console.WriteLine("User {0} logged in", currentUser.employeeID);
            return;
        }
        //allows the most recent user to log out
        //will only allow a logout if you are logged in
        public void employeeLogout(Employee logout)
        {
            if (currentUser.employeeID == logout.employeeID)
            {
                System.Console.WriteLine("User {0} logged out", currentUser.employeeID);
                currentUser = null;
            }
            //if someone other than current user attemps to log out print error message
            else
                System.Console.WriteLine("Only the current user can log out");
            return;
        }
        //set store based on which store created the register
        //register ID and start of day cash are fixed
        //our prototype assumes 1 register and 1 day of operations
        public CashRegister(Store parentStore)
        {
            store = parentStore;
            registerID = 3312000;
            currentCash = 200;
            currentUser = null;
        }
    }
}
