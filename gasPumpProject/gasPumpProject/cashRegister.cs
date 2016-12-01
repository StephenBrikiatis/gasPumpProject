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
        private int registerID { get; }
        //cash in this register
        private int currentCash { get; set; }
        //0 if nobody is logged in
        private int currentUser;
        //store that owns this register
        private Store store;
        //called from Store.prePayPump() when a customer wants to pay cash for gas
        //updates cash in register, pump's prepay value, and state of pump (cash mode)
        //alerts store to the transaction so store can update its records
        public bool payForFuel(int targetPump, int paymentAmnt)
        {
            if (currentUser == 0)
                return false;
            currentCash += paymentAmnt;
            store.receivePumpPay(paymentAmnt);
            store.fuelPumps[targetPump].prepaid.set(paymentAmnt);
            store.fuelPumps[targetPump].setState(1);
            return true;
        }

    }
}
