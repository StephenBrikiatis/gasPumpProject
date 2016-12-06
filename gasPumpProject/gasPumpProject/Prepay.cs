using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    class Prepay : PumpState
    {
        FuelPump parent;
        public Prepay(FuelPump pump)
        {
            parent = pump;
        }
        public override void usePump()
        {
            Console.WriteLine("ERR: Wrong State");
            return;
        }

        public override float usePump(int paymentType, int typeOfGas, float amountOfGas)
        {
            return 0;
        }
    }
}
