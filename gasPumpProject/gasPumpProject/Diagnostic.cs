using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{

    class Diagnostic : PumpState
    {
        FuelPump parent;
        public Diagnostic(FuelPump pump)
        {
            parent = pump;
        }

        public override void usePump()
        {
            Console.WriteLine("Fuel Remaining Reg: {0}, Prem: {1}, Super: {2}",
                parent.getCurrentGas((int)fuelType.regular),
                parent.getCurrentGas((int)fuelType.premium),
                parent.getCurrentGas((int)fuelType.super));
            parent.setState((int)pumpState.card);
            return;
        }

        public override float usePump(int a, int b, float c) 
        {
            Console.WriteLine("ERR: Wrong State");
            parent.setState((int)pumpState.card);
            return (float)function.failure;
        }
    }
}
