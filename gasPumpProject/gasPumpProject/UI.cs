using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    class UI
    {
        Store store;

        public void customerOrEmployee()
        {
            //Decide if user is using system as a customer or an employee
            System.Console.WriteLine("Are you a customer or an employee (select by number)?");
            System.Console.WriteLine("1. Customer");
            System.Console.WriteLine("2. Employee");
            bool isEmployee;
            if (Int32.Parse(Console.ReadLine()) == 2)
                isEmployee = true;
            else
                isEmployee = false;
            //If they're an employee
            if (isEmployee)
            {
                Console.WriteLine("Would you like to work the register or diagnose pumps?");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Pumps");
                if (Int32.Parse(Console.ReadLine()) == 2)
                    diagnosePumps();
                else
                    loginToRegister();
            }

            else
                pickAPump();
            return;

        }

        private void pickAPump()
        {
            for(int i = 0; i < 3; i++)
            {
                if (store.pumps[i].inUse == false)
                {
                    buyGas(i);
                }
            }
        }
        
        public void buyGas(int pumpNumber)
        {
            int paymentType = 0, fuelType = 0; //payment checks if the user is using credit, debit or cash
            //fuel type check for which type of gas will be used and is geting the item from the fuelTank array
            float amount = 0;
            //Amount is either the amount of gas (for cardpay), or the amount paid (for cashpay)

            paymentType = payType();
            fuelType = gasSelect();
            if (paymentType != 0)
                amount = getGasAmount();
            else
                amount = getPayAmount();
            store.pumps[pumpNumber].customerUP(paymentType, fuelType, amount);
        }

        private int payType()
        {
            int typeOfPayment;
            Console.Out.WriteLine("Are you using cash, credit, debit (0 for cash, 1 for credit, 2 for debit):");
            typeOfPayment = Convert.ToInt32(Console.ReadLine());

            return typeOfPayment;
        }
        
        private int gasSelect()
        {
            int typeOfGas;
            Console.Out.WriteLine("Enter the type of gas you would like (1 for regular, 2 for premium, 3 for super): ");
            typeOfGas = Convert.ToInt32(Console.ReadLine());
            return typeOfGas;
        }

        private float getGasAmount()
        {
            float amountOfGas;
            Console.Out.WriteLine("Enter the number of gallons of gas you want to pay for: ");
            amountOfGas = Convert.ToSingle(Console.ReadLine());
            return amountOfGas;
        }

        private float getPayAmount()
        {
            float amountOfCash;
            Console.Out.WriteLine("Enter the number of dollars worth of gas you would like to buy");
            amountOfCash = Convert.ToSingle(Console.ReadLine());
            return amountOfCash;
        }

        //user is exploring the system as an employee, they have run the pump diagnostics
        private void diagnosePumps()
        {

        }
        //user is exploring the system as an employee, they are attempting to use the register
        private void loginToRegister()
        {
            store.register.employeeLogin(store.employees[2]);
            store.register.employeeLogout(store.employees[0]);
            store.register.employeeLogin(store.employees[2]);
        }
    }
}
