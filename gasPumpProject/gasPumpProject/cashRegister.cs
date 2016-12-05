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
    class cashRegister
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
        public int payForFuel(int targetPump, int paymentAmnt)
        {
            //cannot pay at register if no employee is logged in
            if (currentUser == null)
                return (int)function.failure;
            //update cash in register to reflect payment
            currentCash += paymentAmnt;
            //alert store to transaction so database can be updated
            store.receivePumpPay(paymentAmnt);
            //set the state of the chosen pump and the prepayment amount
            store.fuelPumps[targetPump].prepaid.set(paymentAmnt);
            store.fuelPumps[targetPump].setState(1);
            return true;
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
            return;
        }
        //allows the most recent user to log out
        //will only allow a logout if you are logged in
        public void employeeLogout(Employee logout)
        {
            if (currentUser.employeeID == logout.employeeID)
                currentUser = null;
            //if someone other than current user attemps to log out print error message
            else
                System.Console.WriteLine("Only the current user can log out");
            return;
        }
    }
}